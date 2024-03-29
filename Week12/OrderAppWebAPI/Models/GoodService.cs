﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAppWebAPI.Models
{
    public class GoodService
    {
        public static void Add(Good goods)
        {
            try
            {
                using (var db = new OrderContext())
                {
                    db.Goods.Add(goods);
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                //TODO 需要更加错误类型返回不同错误信息
                throw new ApplicationException($"添加错误!");
            }
        }

        public static void Clear()
        {
            using (var db = new OrderContext())
            {
                //db.Goods.Remove()
            }
        }

        public static List<Good> GetAll()
        {
            using (var db = new OrderContext())
            {
                return db.Goods.ToList();
            }
        }
    }
}
