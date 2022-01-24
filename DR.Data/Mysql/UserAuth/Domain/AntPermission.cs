using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DR.Data.Mysql.UserAuth.Domain
{
    [Table("ant_permission")]
    public class AntPermission
    {
        /// <summary>
        ///
        /// <summary>
        public string id { get; set; }
        /// <summary>
        ///权限节点code值
        /// <summary>
        public string code { get; set; }
        /// <summary>
        ///权限名称
        /// <summary>
        public string title { get; set; }
        /// <summary>
        ///排序
        /// <summary>
        public int sort { get; set; }
        /// <summary>
        ///父节点
        /// <summary>
        public string parent_id { get; set; }
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
