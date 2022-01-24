using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DR.Data.Mysql.Activity.Domain
{
    [Table("platform_config")]
    public class PlatformConfig
    {
        /// <summary>
        ///唯一ID
        /// <summary>
        public string id { get; set; }
        /// <summary>
        ///
        /// <summary>
        public int platform_code { get; set; }
        /// <summary>
        ///平台名称
        /// <summary>
        public string platform_name { get; set; }
        /// <summary>
        ///排序编号(后台获取最大sort_no + 1)
        /// <summary>
        public int sort_no { get; set; }
        /// <summary>
        ///是否可用, 默认为1。 0：否；1：是
        /// <summary>
        public int is_usable { get; set; }
        /// <summary>
        ///图片路径
        /// <summary>
        public string image_url { get; set; }
        /// <summary>
        ///平台状态 0 正常 1维护
        /// <summary>
        public int plat_status { get; set; }
        /// <summary>
        ///平台状态 0 正常 1维护
        /// <summary>
        public int wallet_status { get; set; }
        /// <summary>
        ///更新时间
        /// <summary>
        public DateTime update_time { get; set; }
        /// <summary>
        ///0不是seamless  1 是seamless
        /// <summary>
        public int is_seamless { get; set; }
        /// <summary>
        ///0不包含老虎机  1 包含老虎机
        /// <summary>
        public int is_slot { get; set; }
        /// <summary>
        ///所属代理商
        /// <summary>
        public string agent_code { get; set; }
        /// <summary>
        ///平台pc图片
        /// <summary>
        public string pc_image_url { get; set; }
        /// <summary>
        ///0 主钱包 1老虎机钱包  2真人钱包 3 体育竞技钱包  4 捕鱼 棋牌  彩票账户 
        /// <summary>
        public int wallet_type { get; set; }
        /// <summary>
        ///钱包名字
        /// <summary>
        public string wallet_name { get; set; }
        /// <summary>
        ///游戏平台的json配置值
        /// <summary>
        public string game_setting { get; set; }
        /// <summary>
        ///0 1
        /// <summary>
        public int system_status { get; set; }
        /// <summary>
        ///平台所属站点
        /// <summary>
        public string zhandian { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string en_name { get; set; }
        /// <summary>
        ///百分比费率
        /// <summary>
        public int fee { get; set; }
        /// <summary>
        ///0 所有  1只能为 整数
        /// <summary>
        public int transfer_unit { get; set; }
        /// <summary>
        ///merchant id   merchant1,merchant2,merchant3
        /// <summary>
        public string cids { get; set; }
    }
}
