using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DR.Data.Mysql.UserAuth.Domain
{
    [Table("user_washcode")]
    public class UserWashcode
    {
        /// <summary>
        ///
        /// <summary>
        public string id { get; set; }
        /// <summary>
        ///待领取总额
        /// <summary>
        public decimal wait_total_amount { get; set; }
        /// <summary>
        ///今日获取额度
        /// <summary>
        public decimal today_amount { get; set; }
        /// <summary>
        ///更新时间
        /// <summary>
        public DateTime update_time { get; set; }
        /// <summary>
        ///用户名
        /// <summary>
        public string username { get; set; }
        /// <summary>
        ///流水code值
        /// <summary>
        public string code { get; set; }
        /// <summary>
        ///超额
        /// <summary>
        public decimal excess_amount { get; set; }
        /// <summary>
        ///已领取反水
        /// <summary>
        public decimal received_amount { get; set; }
    }
}
