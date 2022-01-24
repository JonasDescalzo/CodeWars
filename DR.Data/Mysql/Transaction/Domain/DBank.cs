using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DR.Data.Mysql.Transaction.Domain
{
    [Table("d_bank")]
    public class DBank
    {
        /// <summary>
        ///
        /// <summary>
        public string id { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string bank_name { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string bank_number { get; set; }
        /// <summary>
        ///
        /// <summary>
        public DateTime create_time { get; set; }
        /// <summary>
        ///0 可用  1 不可用
        /// <summary>
        public string status { get; set; }
        /// <summary>
        ///为空，则所有组都可用，多个组用逗号隔开
        /// <summary>
        public string user_groupid { get; set; }
        /// <summary>
        ///
        /// <summary>
        public int sort { get; set; }
        /// <summary>
        ///姓名
        /// <summary>
        public string real_name { get; set; }
        /// <summary>
        ///分行地址
        /// <summary>
        public string address { get; set; }
        /// <summary>
        ///更新时间
        /// <summary>
        public DateTime update_time { get; set; }
        /// <summary>
        ///创建者
        /// <summary>
        public string create_by { get; set; }
        /// <summary>
        ///更新者
        /// <summary>
        public DateTime update_by { get; set; }
        /// <summary>
        ///所属站点
        /// <summary>
        public string zhandian { get; set; }
        /// <summary>
        ///印度ifsc
        /// <summary>
        public string ifsccode { get; set; }
        /// <summary>
        ///0 不是QR 1是QR
        /// <summary>
        public int isqr { get; set; }
        /// <summary>
        ///qr image url
        /// <summary>
        public string qr_url { get; set; }
        /// <summary>
        ///所属国家
        /// <summary>
        public string country_code { get; set; }
        /// <summary>
        ///0 jeet 1 eu
        /// <summary>
        public int type { get; set; }
        /// <summary>
        ///
        /// <summary>
        public int is_test { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string level { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string finance_user { get; set; }
        /// <summary>
        ///merchantid
        /// <summary>
        public string cid { get; set; }
    }
}
