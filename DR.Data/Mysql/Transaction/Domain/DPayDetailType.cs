using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DR.Data.Mysql.Transaction.Domain
{
    [Table("d_pay_detail_type")]
    public class DPayDetailType
    {
        /// <summary>
        ///
        /// <summary>
        public string id { get; set; }
        /// <summary>
        ///主支付id
        /// <summary>
        public string pay_type_id { get; set; }
        /// <summary>
        ///支付名
        /// <summary>
        public string pay_detail_name { get; set; }
        /// <summary>
        ///图片路径
        /// <summary>
        public string image_url { get; set; }
        /// <summary>
        ///更新时间
        /// <summary>
        public DateTime update_time { get; set; }
        /// <summary>
        ///0 正常 1
        /// <summary>
        public int status { get; set; }
        /// <summary>
        ///排序
        /// <summary>
        public int sort { get; set; }
        /// <summary>
        ///pc 图片路径
        /// <summary>
        public string pc_image_url { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string en_name { get; set; }
        /// <summary>
        ///默认1.0  新版只请求2.0 数据
        /// <summary>
        public string version { get; set; }
        /// <summary>
        ///merchantid
        /// <summary>
        public string cid { get; set; }
    }
}
