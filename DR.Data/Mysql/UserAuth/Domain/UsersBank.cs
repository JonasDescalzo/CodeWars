using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DR.Data.Mysql.UserAuth.Domain
{
    [Table("users_bank")]
    public class UsersBank
    {
        /// <summary>
        ///
        /// <summary>
        public string id { get; set; }
        /// <summary>
        ///用户名
        /// <summary>
        public string user_name { get; set; }
        /// <summary>
        ///银行卡号
        /// <summary>
        public string bank_number { get; set; }
        /// <summary>
        ///银行名称
        /// <summary>
        public string bank_name { get; set; }
        /// <summary>
        ///是否被删除 0 正常 1被删除
        /// <summary>
        public int is_delete { get; set; }
        /// <summary>
        ///创建时间
        /// <summary>
        public DateTime create_time { get; set; }
        /// <summary>
        ///银行code值
        /// <summary>
        public string bank_code { get; set; }
        /// <summary>
        ///省
        /// <summary>
        public string province { get; set; }
        /// <summary>
        ///市
        /// <summary>
        public string city { get; set; }
        /// <summary>
        ///印度IFSC
        /// <summary>
        public string bank_ifsc { get; set; }

        /// <summary>
        /// 真实姓名
        /// </summary>
        public string real_name { get; set; }

        public string cid { get; set; }
    }
}
