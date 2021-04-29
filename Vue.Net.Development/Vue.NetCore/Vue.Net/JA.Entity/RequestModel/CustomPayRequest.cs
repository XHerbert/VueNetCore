﻿using System;
using System.Collections.Generic;
using System.Text;

namespace JA.Entity.RequestModel
{
    public class CustomPayRequest
    {
        /// <summary>
        /// 缴费专号
        /// </summary>
        public int CUST_ID { get; set; }
        /// <summary>
        /// 账期
        /// </summary>
        public string DL_TERM { get; set; }
        /// <summary>
        /// 缴费金额
        /// </summary>
        public int TX_AMOUNT { get; set; }
        /// <summary>
        /// 凭证流水
        /// </summary>
        public int TX_SERIAL_NO { get; set; }
    }
}
