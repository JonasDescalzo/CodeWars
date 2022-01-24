using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DR.Data.Mysql.UserAuth.Domain
{
    [Table("user_washcode_type")]
    public class UserWashCodeType
    {
        public string id { get; set; }

        /// <summary>
        ///反水名称
        /// <summary>
        public string title { get; set; }
        /// <summary>
        ///图片路径
        /// <summary>
        public string image_url { get; set; }
        /// <summary>
        ///反水code值
        /// <summary>
        public string code { get; set; }

        public int sort { get; set; }
    }
}
