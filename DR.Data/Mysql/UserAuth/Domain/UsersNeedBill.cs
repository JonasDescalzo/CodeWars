using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DR.Data.Mysql.UserAuth.Domain
{
    [Table("user_needbill")]
    public class UsersNeedBill
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
        ///所需通用流水
        /// <summary>
        public decimal need_gamebill { get; set; }
        /// <summary>
        ///所需体育流水
        /// <summary>
        public decimal need_sportsbill { get; set; }
        /// <summary>
        ///创建时间
        /// <summary>
        public DateTime create_time { get; set; }
        /// <summary>
        ///更新时间
        /// <summary>
        public DateTime update_time { get; set; }

    }
}
