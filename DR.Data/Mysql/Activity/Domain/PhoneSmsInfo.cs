using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DR.Data.Mysql.Activity.Domain
{
    [Table("phone_sms_info")]
    public class PhoneSmsInfo
    {
        /// <summary>
        ///主键
        /// <summary>
        public string id { get; set; }
        /// <summary>
        ///手机号
        /// <summary>
        public string phone { get; set; }
        /// <summary>
        ///发送总次数
        /// <summary>
        public int total_count { get; set; }
        /// <summary>
        ///更新时间
        /// <summary>
        public DateTime update_time { get; set; }
        /// <summary>
        ///过期时间
        /// <summary>
        public DateTime expried_time { get; set; }
        /// <summary>
        ///验证码值
        /// <summary>
        public string captcha_code { get; set; }
        /// <summary>
        ///下次可发送时间
        /// <summary>
        public DateTime next_time { get; set; }
        /// <summary>
        ///merchant id
        /// <summary>
        public string cid { get; set; }
    }
}
