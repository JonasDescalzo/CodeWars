using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DR.Data.Mysql.Game.Domain
{
    [Table("log_schedule")]
    public class LogSchedule
    {
        /// <summary>
        ///自增主键
        /// <summary>
        public int Id { get; set; }
        /// <summary>
        ///平台名称
        /// <summary>
        public string plat_name { get; set; }
        /// <summary>
        ///拉取流水区间开始时间
        /// <summary>
        public DateTime start_time { get; set; }
        /// <summary>
        ///拉取流水区间结束时间
        /// <summary>
        public DateTime end_time { get; set; }
        /// <summary>
        ///1 为正在进行  200 成功 其它失败
        /// <summary>
        public int status { get; set; }
        /// <summary>
        ///失败或者成功信息
        /// <summary>
        public string msg { get; set; }
        /// <summary>
        ///创建时间
        /// <summary>
        public DateTime create_time { get; set; }
        /// <summary>
        ///更新时间
        /// <summary>
        public DateTime update_time { get; set; }
        /// <summary>
        ///加载数量
        /// <summary>
        public int load_count { get; set; }
        /// <summary>
        ///查询游标最后一排
        /// <summary>
        public int last_key { get; set; }
    }
}
