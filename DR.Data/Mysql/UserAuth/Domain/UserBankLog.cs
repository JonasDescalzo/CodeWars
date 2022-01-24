using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DR.Data.Mysql.UserAuth.Domain
{
    [Table("user_bank_log")]
    public class UserBankLog
    {
        /// <summary>
        ///id
        /// <summary>
        public string id { get; set; }
        /// <summary>
        ///银行名称
        /// <summary>
        public string bank_name { get; set; }
        /// <summary>
        ///银行卡号
        /// <summary>
        public string bank_number { get; set; }
        /// <summary>
        ///用户名
        /// <summary>
        public string user_name { get; set; }
        /// <summary>
        ///操作时间
        /// <summary>
        public DateTime date { get; set; }
        /// <summary>
        ///操作名称 绑定与解绑
        /// <summary>
        public string status_name { get; set; }
        /// <summary>
        ///操作时的真实姓名
        /// <summary>
        public string real_name { get; set; }
        /// <summary>
        ///省
        /// <summary>
        public string province { get; set; }
        /// <summary>
        ///市
        /// <summary>
        public string city { get; set; }
        /// <summary>
        ///cid
        /// <summary>
        public string cid { get; set; }
    }
}
