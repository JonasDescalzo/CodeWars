using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DR.Data.Mysql.UserAuth.Domain
{
    [Table("ant_role")]
    public class AntRole
    {
        /// <summary>
        ///
        /// <summary>
        public string id { get; set; }
        /// <summary>
        ///角色名字
        /// <summary>
        public string title { get; set; }
        /// <summary>
        ///排序
        /// <summary>
        public int sort { get; set; }
        /// <summary>
        ///角色code值
        /// <summary>
        public string code { get; set; }
        /// <summary>
        ///创建时间
        /// <summary>
        public DateTime create_time { get; set; }
        /// <summary>
        ///更新时间
        /// <summary>
        public DateTime update_time { get; set; }
        /// <summary>
        ///父Id
        /// <summary>
        public string parent_id { get; set; }
        /// <summary>
        ///
        /// <summary>
        public decimal bonus_max_month { get; set; }
        /// <summary>
        ///
        /// <summary>
        public decimal bonus_max_order { get; set; }
        /// <summary>
        ///merchant id
        /// <summary>
        public string cid { get; set; }
    }
}
