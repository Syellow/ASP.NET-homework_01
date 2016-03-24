﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eSale.Models
{
    /// <summary>
    /// 訂單服務
    /// </summary>
    public class OrderService
    {
        /// <summary>
        /// 新增訂單
        /// </summary>
        public void InsertOrder()
        {

        }

        /// <summary>
        /// 刪除訂單
        /// </summary>
        public void DeleteOrderById()
        {

        }

        /// <summary>
        /// 更新訂單
        /// </summary>
        public void UpdateOrder()
        {

        }

        /// <summary>
        /// 取得訂單
        /// </summary>
        /// <param name="id">訂單ID</param>
        /// <returns></returns>
        public Models.Order GetOrderById(string id)
        {
            Models.Order result = new Order();
            result.CustId = "111";
            result.CustName = "mis";
            return result;
        }

        /// <summary>
        /// 取得訂單(多筆)
        /// </summary>
        /// <returns></returns>
        public List<Models.Order> GetOrder()
        {
            return new List<Order>();
        }
    }
}