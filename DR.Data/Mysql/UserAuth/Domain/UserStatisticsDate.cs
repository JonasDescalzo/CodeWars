using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DR.Data.Mysql.UserAuth.Domain
{
    [Table("user_statistics_date")]
    public class UserStatisticsDate
    {
        /// <summary>
        ///
        /// <summary>
        public string id { get; set; }
        /// <summary>
        ///用户名
        /// <summary>
        public string username { get; set; }
        /// <summary>
        ///时间
        /// <summary>
        public DateTime date { get; set; }
        /// <summary>
        ///总输赢
        /// <summary>
        public decimal total_winlose { get; set; }
        /// <summary>
        ///红利反水
        /// <summary>
        public decimal bonus_rebates { get; set; }
        /// <summary>
        ///有效流水
        /// <summary>
        public decimal rollover { get; set; }
        /// <summary>
        ///存款
        /// <summary>
        public decimal deposit { get; set; }
        /// <summary>
        ///取款
        /// <summary>
        public decimal withdrawal { get; set; }
        /// <summary>
        ///所属代理推荐码
        /// <summary>
        public string recommend { get; set; }
    }
}
