using System;
using System.Collections.Generic;
using System.Text;

namespace DR.Data.Elasticserch.Domain
{
    public class ElTransactionSummaryModel
    {
        public string Id { get; set; }

        public string PlatCode { get; set; }

        public string PlatName { get; set; }

        public string UserName { get; set; }

        public int Dateymd { get; set; }

        public string Currency { get; set; } = "";

        /// <summary>
        /// 下注金额
        /// </summary>
        public decimal BetAmount { get; set; }

        /// <summary>
        /// 赢取金额 等于下注加上已赢取部分
        /// </summary>
        public decimal WinAmount { get; set; }

        /// <summary>
        /// 投资有效金额
        /// </summary>
        public decimal TzAmount { get; set; }

        /// <summary>
        /// 有效的下注金额
        /// </summary>
        public decimal EffectiveBetAmount { get; set; }

        /// <summary>
        /// 无效的下注金额
        /// </summary>
        public decimal InvalidBetAmount { get; set; }
    }
}
