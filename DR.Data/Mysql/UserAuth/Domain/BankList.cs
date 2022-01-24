using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DR.Data.Mysql.UserAuth.Domain
{
    [Table("bank_list")]
    public class BankList
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
        public string bank_code { get; set; }
        /// <summary>
        ///0 可用 1 不可用
        /// <summary>
        public int status { get; set; }
        /// <summary>
        ///
        /// <summary>
        public int sort { get; set; }
        /// <summary>
        ///银行logo
        /// <summary>
        public string img_logo { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string zhandian { get; set; }
        /// <summary>
        ///银行
        /// <summary>
        public string yp_code { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string country_code { get; set; }
        /// <summary>
        ///merichant id
        /// <summary>
        public string cid { get; set; }
    }
}
