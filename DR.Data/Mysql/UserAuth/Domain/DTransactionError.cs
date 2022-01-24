using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DR.Data.Mysql.UserAuth.Domain
{
    [Table("d_transaction_error")]
    public class DTransactionError
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
        ///订单id
        /// <summary>
        public string order_id { get; set; }
        /// <summary>
        ///平台code值
        /// <summary>
        public string plat_code { get; set; }
        /// <summary>
        ///时间
        /// <summary>
        public DateTime create_time { get; set; }
        /// <summary>
        ///金额
        /// <summary>
        public decimal amount { get; set; }
        /// <summary>
        ///0 出  1 进
        /// <summary>
        public int outorin { get; set; }
        /// <summary>
        ///0 没有检查  1已经检查
        /// <summary>
        public int check { get; set; }
    }
}
