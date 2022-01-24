using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DR.Data.Mysql.Activity.Domain
{
    [Table("promo_config")]
    public class PromoConfig
    {
        /// <summary>
        ///唯一ID
        /// <summary>
        public string id { get; set; }
        /// <summary>
        ///推广标题
        /// <summary>
        public string title { get; set; }
        /// <summary>
        ///推广icon
        /// <summary>
        public string icon { get; set; }
        /// <summary>
        ///图片
        /// <summary>
        public string image_src { get; set; }
        /// <summary>
        ///排序索引：取最大值加1
        /// <summary>
        public int sort_index { get; set; }
        /// <summary>
        ///排序编号(后台获取最大sort_no + 1)
        /// <summary>
        public int sort_no { get; set; }
        /// <summary>
        ///推广子名称
        /// <summary>
        public string sub_title { get; set; }
        /// <summary>
        ///是否可用, 默认为1。 0：否；1：是
        /// <summary>
        public int is_usable { get; set; }
        /// <summary>
        ///推广信息描述
        /// <summary>
        public string promo_desc { get; set; }
        /// <summary>
        ///推广链接
        /// <summary>
        public string link { get; set; }
        /// <summary>
        ///打开方式：1 popup, 2 new page
        /// <summary>
        public int open_type { get; set; }
        /// <summary>
        ///推广内容
        /// <summary>
        public string content { get; set; }
        /// <summary>
        ///
        /// <summary>
        public int pro_type { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string pro_type_name { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string end_time { get; set; }
        /// <summary>
        ///创建时间
        /// <summary>
        public DateTime create_time { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string open_url { get; set; }
        /// <summary>
        ///
        /// <summary>
        public int pro_tag_type { get; set; }
        /// <summary>
        ///
        /// <summary>
        public int is_go_out { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string pc_image_src { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string pc_link { get; set; }
        /// <summary>
        ///
        /// <summary>
        public int is_delete { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string pc_content { get; set; }
        /// <summary>
        ///所属代理商
        /// <summary>
        public string agent_code { get; set; }
        /// <summary>
        ///所属站点
        /// <summary>
        public string zd { get; set; }
        /// <summary>
        ///新版手机图片
        /// <summary>
        public string new_image_src { get; set; }
        /// <summary>
        ///所属国家
        /// <summary>
        public string country_code { get; set; }
        /// <summary>
        ///merchant id
        /// <summary>
        public string cid { get; set; }
    }
}
