using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DR.Data.Mysql.UserAuth.Domain
{
    [Table("aff_domain")]
    public class AffDomain
    {
        /// <summary>
        ///
        /// <summary>
        public string id { get; set; }
        /// <summary>
        ///域名
        /// <summary>
        public string domain { get; set; }
        /// <summary>
        ///代理名
        /// <summary>
        public string aff_username { get; set; }
        /// <summary>
        ///时间
        /// <summary>
        public DateTime createtime { get; set; }
    }
}
