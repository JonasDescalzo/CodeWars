using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DR.Data.Mysql.Activity.Domain
{
    [Table("banner_config")]
    public class BannerConfig
    {
        /// <summary>
        ///唯一ID
        /// <summary>
        public string id { get; set; }
        /// <summary>
        ///标语名称
        /// <summary>
        public string title { get; set; }
        /// <summary>
        ///标语icon
        /// <summary>
        public string icon_src { get; set; }
        /// <summary>
        ///图片
        /// <summary>
        public string image_src { get; set; }
        /// <summary>
        ///排序索引：每次取最大+1
        /// <summary>
        public int sort_index { get; set; }
        /// <summary>
        ///排序编号(后台获取最大sort_no + 1)
        /// <summary>
        public int sort_no { get; set; }
        /// <summary>
        ///是否可用, 默认为1。 0：否；1：是
        /// <summary>
        public int is_usable { get; set; }
        /// <summary>
        ///标语信息描述
        /// <summary>
        public string banner_desc { get; set; }
        /// <summary>
        ///推广链接
        /// <summary>
        public string link { get; set; }
        /// <summary>
        ///打开方式：1 popup, 2 new page
        /// <summary>
        public int open_type { get; set; }
        /// <summary>
        ///创建时间
        /// <summary>
        public DateTime create_time { get; set; }
        /// <summary>
        ///
        /// <summary>
        public int jump_type { get; set; }
        /// <summary>
        ///
        /// <summary>
        public int is_delete { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string pc_link { get; set; }
        /// <summary>
        ///所属代理商
        /// <summary>
        public string agent_code { get; set; }
        /// <summary>
        ///站点
        /// <summary>
        public string zd { get; set; }

        public string new_image_src { get; set; }

        public string back_color { get; set; }

        public string newapp_link { get; set; }

        public string country_code { get; set; }
        public string cid { get; set; }
    }
}
