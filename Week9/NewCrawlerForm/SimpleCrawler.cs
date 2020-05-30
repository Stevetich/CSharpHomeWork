using System;
using System.Collections;
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
        public event Action<Crawler, string> PageDownloaded;

        public Hashtable urls = new Hashtable();
        private int count = 0;
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
            Match();

            //Console.WriteLine("开始爬行了.... ");
            while (true)
            {
                string current = null;
                foreach (string url in urls.Keys)
                {
                    if ((bool)urls[url]) continue;
                    current = url;
                }

                if (current == null || count > 20) break;
                //Console.WriteLine("爬行" + current + "页面!");
                string html = DownLoad(current); // 下载
                urls[current] = true;
                count++;
                PageDownloaded(this, current);
                Parse(html, current);//解析,并加入新的链接
                //Console.WriteLine("爬行结束");
            }
            //Console.ReadLine();
        }

        public string DownLoad(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);
                string fileName = count.ToString();
                File.WriteAllText(fileName, html, Encoding.UTF8);
                return html;
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);
                return "";
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
                    if (urls[url] == null)
                        urls[url] = false;
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
                
                if (urls[absolute.ToString()] == null)
                    urls[absolute.ToString()] = false;
            }
        }
    }
}
