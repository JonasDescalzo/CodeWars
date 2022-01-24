using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DR.Data.Mysql.UserAuth.Domain
{
    [Table("aff_date_data")]
    public class AffDateData
    {
        public string id { get; set; }

        /// <summary>
        ///日期
        /// <summary>
        public DateTime date { get; set; }
        /// <summary>
        ///注册会员
        /// <summary>
        public int register_count { get; set; }
        /// <summary>
        ///下线首冲
        /// <summary>
        public int member_first { get; set; }
        /// <summary>
        ///总存款
        /// <summary>
        public decimal total_deposit { get; set; }
        /// <summary>
        ///存款人数
        /// <summary>
        public int deposit_count { get; set; }
        /// <summary>
        ///总提款
        /// <summary>
        public decimal total_withdrawal { get; set; }
        /// <summary>
        ///提款人数
        /// <summary>
        public int withdrawal_count { get; set; }
        /// <summary>
        ///总输赢
        /// <summary>
        public decimal total_winlost { get; set; }
        /// <summary>
        ///总返水红利
        /// <summary>
        public decimal total_divend { get; set; }
        /// <summary>
        ///净输赢
        /// <summary>
        public decimal net_winlost { get; set; }

        public string username { get; set; }

        public int new_deposit_count { get; set; }
    }
}
