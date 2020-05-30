using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleCrawler
{

    class Crawler
    {
        public event Action<Crawler, CustomURL> PageDownloaded;

        public ConcurrentBag<CustomURL> urls = new ConcurrentBag<CustomURL>();
        public int count = 0;
        static public string startUrl { get; set; }
        static public string startWith { get; set; }

        public void Match()
        {
            try
            {
                string matchRule = @"(www\.){0,1}.*?\..*?/";
                Regex regex = new Regex(matchRule);
                Match match = regex.Match(startUrl);
                startWith = match.Value;
            }
            catch
            {

            }
        }


        public void Crawl()
        {
            CustomURL surl = new CustomURL() { url = startUrl, processing = false, html = "" };
            urls.Add(surl);
            Match();

            while (true)
            {
                CustomURL current = null;
                foreach (var url in urls)
                {
                    if (url.processing) continue;
                    current = url;
                    if (count > 100)
                        break;
                    if (current == null)
                        continue;
                    current.processing = true;
                    var t = new Thread(() => Start(current));
                    t.Start();
                    count++;
                }
            }
        }

        public bool isExsisted(string url)
        {

            foreach (CustomURL u in urls)
            {
                if (u.url == url) return true;
            }
            return false;
        }

        public void Start(CustomURL url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url.url);
                string fileName = count.ToString();
                File.WriteAllText(fileName, html, Encoding.UTF8);
                url.html = html;
                PageDownloaded(this, url);
                Parse(html, url.url);
            }
            catch (Exception e)
            {

            }
        }

        private void Parse(string html, string pageUrl)
        {
            string strRule = @"(href|HREF)[ ]*=[ ]*[""'](http|https)[^""'#>]+..html.*?[""']";
            MatchCollection matches = new Regex(strRule).Matches(html);
            foreach (Match match in matches)
            {
                var url = match.Value.Substring(match.Value.IndexOf('=') + 1).Trim('"', '\"', '#', '>');
                if (url.Length == 0)
                    continue;
                //仅包含起始网站上的网页
                if (url.Contains(startWith))
                {
                    if (!isExsisted(url))
                    {
                        urls.Add(new CustomURL() { url = url, processing = false, html = "" });
                    }

                }
            }

            strRule = @"(href|HREF)[ ]*=[ ]*[""'][^(http|https)][^""'#>]+..html.*?[""']";
            matches = new Regex(strRule).Matches(html);
            foreach (Match match in matches)
            {
                var url = match.Value.Substring(match.Value.IndexOf('=') + 1).Trim('"', '\"', '#', '>');
                if (url.Length == 0) continue;
                
                Uri baseUri = new Uri(pageUrl);
                Uri absolute = new Uri(baseUri,url);

                if (url.Contains(startWith))
                {
                    if (!isExsisted(url))
                    {
                        urls.Add(new CustomURL() { url = url, processing = false, html = "" });
                    }
                }
            }
        }

    }
}
