using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DR.Data.Mysql.UserAuth.Domain
{
    [Table("users_letter_read")]
    public class UsersLetterRead
    {
        /// <summary>
        ///
        /// <summary>
        public string id { get; set; }
        /// <summary>
        ///读取信息用户名
        /// <summary>
        public string user_name { get; set; }
        /// <summary>
        ///消息id
        /// <summary>
        public string letter_id { get; set; }
        /// <summary>
        ///读取时间
        /// <summary>
        public DateTime create_time { get; set; }
    }
}
