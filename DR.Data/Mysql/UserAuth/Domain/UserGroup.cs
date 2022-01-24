using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DR.Data.Mysql.UserAuth.Domain
{
    [Table("user_group")]
    public class UserGroup
    {
        /// <summary>
        ///
        /// <summary>
        public string id { get; set; }
        /// <summary>
        ///组别名
        /// <summary>
        public string name { get; set; }
        /// <summary>
        ///所属代理
        /// <summary>
        public string agent { get; set; }
        /// <summary>
        ///当执行此动作时，使用此用户组
        /// <summary>
        public string action { get; set; }
        /// <summary>
        ///cid
        /// <summary>
        public string cid { get; set; }
    }
}
