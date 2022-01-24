using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DR.Data.Mysql.Transaction.Domain
{
    [Table("u_wallert")]
    public class UWallert
    {
        /// <summary>
        ///用户钱包
        /// <summary>
        public string id { get; set; }
        /// <summary>
        ///用户ID
        /// <summary>
        public string uid { get; set; }
        /// <summary>
        ///余额
        /// <summary>
        public decimal balance { get; set; }
        /// <summary>
        ///乐观锁
        /// <summary>
        public int lock_count { get; set; }
        /// <summary>
        ///平台密码
        /// <summary>
        public string password { get; set; }
        /// <summary>
        ///平台ID
        /// <summary>
        public int platform { get; set; }
        /// <summary>
        ///创建时间
        /// <summary>
        public DateTime create_time { get; set; }
        /// <summary>
        ///状态
        /// <summary>
        public int status { get; set; }
        /// <summary>
        ///父级钱包id
        /// <summary>
        public string parentid { get; set; }
        /// <summary>
        ///平台账号
        /// <summary>
        public string platform_account { get; set; }
        /// <summary>
        ///总流水
        /// <summary>
        public decimal all_flow { get; set; }
    }
}
