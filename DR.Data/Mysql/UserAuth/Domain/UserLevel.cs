using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DR.Data.Mysql.UserAuth.Domain
{
    [Table("user_level")]
    public class UserLevel
    {
        /// <summary>
        ///
        /// <summary>
        public string id { get; set; }
        /// <summary>
        ///等级 0-N
        /// <summary>
        public int level { get; set; }
        /// <summary>
        ///该等级的中文名
        /// <summary>
        public string expansion_name { get; set; }
        /// <summary>
        ///更新时间
        /// <summary>
        public DateTime update_time { get; set; }
        /// <summary>
        ///该等级对应等级图标路径
        /// <summary>
        public string image_url { get; set; }
        /// <summary>
        ///晋级周期  1 每周 | 2每月
        /// <summary>
        public string condition_time { get; set; }
        /// <summary>
        ///所需流水
        /// <summary>
        public int condition_flow { get; set; }
        /// <summary>
        ///存款
        /// <summary>
        public int condition_deposit { get; set; }
        /// <summary>
        ///代理
        /// <summary>
        public string agent { get; set; }
        /// <summary>
        ///体育返水比例 万分之
        /// <summary>
        public int sports_washcode { get; set; }
        /// <summary>
        ///真人返水比例  万分之
        /// <summary>
        public int live_washcode { get; set; }
        /// <summary>
        ///棋牌返水比例  万分之
        /// <summary>
        public int chess_washcode { get; set; }
        /// <summary>
        ///休闲电子返水比例 万分之
        /// <summary>
        public int slot_washcode { get; set; }
        /// <summary>
        ///日提款次数
        /// <summary>
        public int withdrawal_count { get; set; }
        /// <summary>
        ///日提款金额
        /// <summary>
        public decimal withdrawal_amount { get; set; }
        /// <summary>
        ///升级礼金
        /// <summary>
        public decimal upgrade_gift { get; set; }
        /// <summary>
        ///每月红包
        /// <summary>
        public decimal month_gift { get; set; }
        /// <summary>
        ///每天领取上限
        /// <summary>
        public decimal day_washcode_upper { get; set; }
        /// <summary>
        ///电子反水比例 万分之
        /// <summary>
        public int yoplay_washcode { get; set; }
        /// <summary>
        ///捕鱼反水比例 万分之
        /// <summary>
        public int fish_washcode { get; set; }
        /// <summary>
        ///所属站点
        /// <summary>
        public string zhandian { get; set; }
        /// <summary>
        ///不同等级每日领取额度
        /// <summary>
        public decimal daily_bonuts_amount { get; set; }
        /// <summary>
        ///merchant id
        /// <summary>
        public string cid { get; set; }
    }
}
