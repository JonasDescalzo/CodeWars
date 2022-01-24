using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DR.Data.Mysql.Activity.Domain
{
    [Table("sports_category")]
    public class SportsCategory
    {
        /// <summary>
        ///
        /// <summary>
        public string id { get; set; }
        /// <summary>
        ///体育分类名
        /// <summary>
        public string category_name { get; set; }
        /// <summary>
        ///排序
        /// <summary>
        public int sort { get; set; }
        /// <summary>
        ///图片路径
        /// <summary>
        public string imageurl { get; set; }
        /// <summary>
        ///平台code值
        /// <summary>
        public string plat_code { get; set; }
        /// <summary>
        ///分类code值
        /// <summary>
        public string category_code { get; set; }
        /// <summary>
        ///0 OK 1 禁止
        /// <summary>
        public int status { get; set; }
    }
}
