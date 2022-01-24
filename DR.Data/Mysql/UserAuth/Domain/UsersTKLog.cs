using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DR.Data.Mysql.UserAuth.Domain
{
    [Table("users_tklog")]
    public class UsersTKLog
    {
        public string id { get; set; }

        public string username { get; set; }

        public DateTime time { get; set; }
    }
}
