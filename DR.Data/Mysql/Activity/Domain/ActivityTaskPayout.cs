using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DR.Data.Mysql.Activity.Domain
{
    [Table("activity_task_payout")]
    public class ActivityTaskPayout
    {
        /// <summary>
        /// 
        /// <summary>
        public string id { get; set; }
        /// <summary>
        ///奖金
        /// <summary>
        public decimal amount { get; set; }
        /// <summary>
        ///是否已被领取 1 已被领取  0 未被领取
        /// <summary>
        public int is_used { get; set; }
        /// <summary>
        ///可领奖最迟时间
        /// <summary>
        public DateTime end_time { get; set; }


        /// <summary>
        ///创建时间
        /// <summary>
        public DateTime create_time { get; set; }
        /// <summary>
        ///标题
        /// <summary>
        public string title { get; set; }
        /// <summary>
        ///详情
        /// <summary>
        public string desc { get; set; }
        /// <summary>
        ///所属活动code
        /// <summary>
        public string bonus_code { get; set; }
        /// <summary>
        ///备注
        /// <summary>
        public string remark { get; set; }
        /// <summary>
        ///用户名
        /// <summary>
        public string username { get; set; }
    }
}
