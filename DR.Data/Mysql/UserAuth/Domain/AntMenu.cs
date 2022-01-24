using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DR.Data.Mysql.UserAuth.Domain
{
    [Table("ant_menu")]
    public class AntMenu
    {
        /// <summary>
        ///
        /// <summary>
        public string id { get; set; }
        /// <summary>
        ///菜单名
        /// <summary>
        public string name { get; set; }
        /// <summary>
        ///顶级id 为0
        /// <summary>
        public string parentId { get; set; }
        /// <summary>
        ///组件名称
        /// <summary>
        public string component { get; set; }
        /// <summary>
        ///跳转路径
        /// <summary>
        public string redirect { get; set; }
        /// <summary>
        ///路径
        /// <summary>
        public string path { get; set; }
        /// <summary>
        ///标题
        /// <summary>
        public string title { get; set; }
        /// <summary>
        ///true 展示  false  隐藏
        /// <summary>
        public bool show { get; set; }
        /// <summary>
        ///图标
        /// <summary>
        public string icon { get; set; }
        /// <summary>
        ///跳转方式
        /// <summary>
        public string target { get; set; }

        public int sort { get; set; }
    }
}
