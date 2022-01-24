using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DR.Data.Mysql.Activity.Domain
{
    [Table("activity_task_bonus")]
    public class ActivityTaskBonus
    {
        /// <summary>
        ///
        /// <summary>
        public string id { get; set; }
        /// <summary>
        ///图片
        /// <summary>
        public string image_url { get; set; }
        /// <summary>
        ///标题
        /// <summary>
        public string title { get; set; }
        /// <summary>
        ///标签
        /// <summary>
        public string label { get; set; }
        /// <summary>
        ///开始时间
        /// <summary>
        public DateTime start_time { get; set; }
        /// <summary>
        ///结束时间
        /// <summary>
        public DateTime end_time { get; set; }
        /// <summary>
        ///验证用到的函数
        /// <summary>
        public string function { get; set; }
        /// <summary>
        ///简介
        /// <summary>
        public string introduction { get; set; }
        /// <summary>
        ///细则url
        /// <summary>
        public string desc_url { get; set; }
        /// <summary>
        ///创建时间
        /// <summary>
        public DateTime create_time { get; set; }
        /// <summary>
        ///活动code值
        /// <summary>
        public string code { get; set; }
        /// <summary>
        ///0 正常  1关闭
        /// <summary>
        public int status { get; set; }
        /// <summary>
        ///1显示 0 不显示
        /// <summary>
        public int is_show { get; set; }
        /// <summary>
        ///领取
        /// <summary>
        public string lq_function { get; set; }
        /// <summary>
        ///排序
        /// <summary>
        public int sort { get; set; }
        /// <summary>
        ///代理编码
        /// <summary>
        public string agent_code { get; set; }
        /// <summary>
        ///流水倍率
        /// <summary>
        public int flow_rate { get; set; }
        /// <summary>
        ///0 所有 1 必须要体育流水
        /// <summary>
        public int only_sports { get; set; }
        /// <summary>
        ///0 普通 1存送 类型
        /// <summary>
        public int cs_type { get; set; }
        /// <summary>
        ///赠送比例 100为基数
        /// <summary>
        public int zs_proportion { get; set; }
        /// <summary>
        ///最高奖金
        /// <summary>
        public decimal high_money { get; set; }
        /// <summary>
        ///所属站点
        /// <summary>
        public string zhandian { get; set; }
        /// <summary>
        ///0 无  1老虎机  2真人  3体育
        /// <summary>
        public int sc_type { get; set; }
        /// <summary>
        ///0 首存  1 每日存送
        /// <summary>
        public int deposti_type { get; set; }
        /// <summary>
        ///1.0 是不用操作的bonus  2.0 是需要操作的bonus
        /// <summary>
        public string version { get; set; }
        /// <summary>
        ///1 被删除 0 正常
        /// <summary>
        public int delete { get; set; }
        /// <summary>
        ///bonus 能用到的国家
        /// <summary>
        public string country { get; set; }
        /// <summary>
        ///bonus 能用到的等级
        /// <summary>
        public string level { get; set; }
        /// <summary>
        /// 用户范围 0 所有  1 指定
        /// <summary>
        public int user_range { get; set; }
        /// <summary>
        ///当用户范围指定时，此用户列表生效
        /// <summary>
        public string user_list { get; set; }
        /// <summary>
        ///金额
        /// <summary>
        public decimal amount { get; set; }
        /// <summary>
        ///优惠码
        /// <summary>
        public string promotion_code { get; set; }
        /// <summary>
        ///优惠码领取人数
        /// <summary>
        public int promotion_count { get; set; }
        /// <summary>
        ///新版手机图片
        /// <summary>
        public string new_image_src { get; set; }
        /// <summary>
        ///已经领取人数
        /// <summary>
        public int claimed_count { get; set; }
        /// <summary>
        ///优惠码父码
        /// <summary>
        public string parent_code { get; set; }
        /// <summary>
        ///流水类型 用于替换sc_type 为空 为通用流水
        /// <summary>
        public string rollover_type { get; set; }
        /// <summary>
        ///流水所属游戏ID ,为空则不具体到游戏
        /// <summary>
        public string rollover_game_code { get; set; }
        /// <summary>
        ///存款
        /// <summary>
        public decimal min_deposit { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string cid { get; set; }
    }
}
