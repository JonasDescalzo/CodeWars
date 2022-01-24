using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DR.Data.Mysql.UserAuth.Domain
{
    [Table("user_register_gift")]
    public class UserRegisterGift
    {
        /// <summary>
        ///id
        /// <summary>
        public string id { get; set; }
        /// <summary>
        ///手机号
        /// <summary>
        public string phone { get; set; }
        /// <summary>
        ///等级
        /// <summary>
        public string level { get; set; }
        /// <summary>
        ///赠送金额
        /// <summary>
        public decimal amount { get; set; }
    }
}
