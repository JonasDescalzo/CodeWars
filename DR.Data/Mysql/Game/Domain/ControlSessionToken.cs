using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DR.Data.Mysql.Game.Domain
{
    [Table("control_sessiontoken")]
    public class ControlSessionToken
    {
        /// <summary>
        ///GUId
        /// <summary>
        public string Id { get; set; }
        /// <summary>
        ///供应商Id
        /// <summary>
        public string vendorid { get; set; }
        /// <summary>
        ///用户名
        /// <summary>
        public string userid { get; set; }
        /// <summary>
        ///币种 比如CNY
        /// <summary>
        public string currency { get; set; }
        /// <summary>
        ///过期时间
        /// <summary>
        public DateTime expiry { get; set; }
        /// <summary>
        ///Token值
        /// <summary>
        public string token { get; set; }
        /// <summary>
        ///0 未使用  1被使用
        /// <summary>
        public int is_used { get; set; }
        /// <summary>
        ///平台code 值
        /// <summary>
        public string plat_code { get; set; }
        /// <summary>
        ///创建时间
        /// <summary>
        public DateTime create_time { get; set; }
        /// <summary>
        ///更新时间
        /// <summary>
        public DateTime update_time { get; set; }
    }
}
