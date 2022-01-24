using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DR.Data.Mysql.Transaction.Domain
{
    [Table("d_pay_type")]
    public class DPayType
    {
        /// <summary>
        ///
        /// <summary>
        public string id { get; set; }
        /// <summary>
        ///支付大类名称
        /// <summary>
        public string pay_name { get; set; }
        /// <summary>
        ///0 正常 1关闭
        /// <summary>
        public int status { get; set; }
        /// <summary>
        ///图片url
        /// <summary>
        public string image_url { get; set; }
        /// <summary>
        ///更新时间
        /// <summary>
        public DateTime update_time { get; set; }
        /// <summary>
        ///排序
        /// <summary>
        public int sort { get; set; }
        /// <summary>
        ///1 扫码支付  2 银行卡转账  3在线支付
        /// <summary>
        public int type { get; set; }
        /// <summary>
        ///提示信息
        /// <summary>
        public string message { get; set; }
        /// <summary>
        ///pc 图片url
        /// <summary>
        public string pc_image_url { get; set; }
        /// <summary>
        ///英文名
        /// <summary>
        public string en_name { get; set; }
        /// <summary>
        ///默认0  1 是新类型适合新版本
        /// <summary>
        public int tz_version { get; set; }
        /// <summary>
        ///新版手机图片
        /// <summary>
        public string new_image { get; set; }
        /// <summary>
        ///非选择状态图片
        /// <summary>
        public string new_image_2 { get; set; }
        /// <summary>
        ///右上角小图标
        /// <summary>
        public string hot_image { get; set; }
        /// <summary>
        ///merchantid
        /// <summary>
        public string cid { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string ex_name { get; set; }
    }
}
