using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DR.Data.Mysql.UserAuth.Domain
{
    [Table("country")]
    public class Country
    {
        /// <summary>
        ///
        /// <summary>
        public string id { get; set; }
        /// <summary>
        ///国家名字
        /// <summary>
        public string name { get; set; }
        /// <summary>
        ///1 正常 0 关闭
        /// <summary>
        public int status { get; set; }
        /// <summary>
        ///该国家注册的人游戏货币
        /// <summary>
        public string currency { get; set; }
        /// <summary>
        ///创建时间
        /// <summary>
        public DateTime create_time { get; set; }
        /// <summary>
        ///国旗图片
        /// <summary>
        public string image_url { get; set; }
        /// <summary>
        ///国家数字代码
        /// <summary>
        public string country_code { get; set; }
        /// <summary>
        ///国家简写
        /// <summary>
        public string country_english_code { get; set; }
        /// <summary>
        ///排序
        /// <summary>
        public int sort { get; set; }

        public string currency_code { get; set; }
    }
}
