using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DR.Data.Mysql.UserAuth.Domain
{
    [Table("aff_commission")]
    public class AffCommission
    {
        /// <summary>
        ///
        /// <summary>
        public string id { get; set; }
        /// <summary>
        ///register count
        /// <summary>
        public int register_count { get; set; }
        /// <summary>
        ///first deposit
        /// <summary>
        public int first_depositor { get; set; }
        /// <summary>
        ///total deposit
        /// <summary>
        public decimal deposit { get; set; }
        /// <summary>
        ///total bonus
        /// <summary>
        public decimal bonus { get; set; }
        /// <summary>
        ///companu_profit(net loss)
        /// <summary>
        public decimal company_profit { get; set; }
        /// <summary>
        ///comission rate
        /// <summary>
        public decimal comission_rate { get; set; }
        /// <summary>
        ///comission
        /// <summary>
        public decimal comission { get; set; }
        /// <summary>
        ///date
        /// <summary>
        public DateTime date { get; set; }
        /// <summary>
        ///create time
        /// <summary>
        public DateTime create_time { get; set; }
        /// <summary>
        ///merchant id
        /// <summary>
        public string cid { get; set; }
    }
}
