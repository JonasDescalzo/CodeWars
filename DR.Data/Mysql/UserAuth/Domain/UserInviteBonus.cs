using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DR.Data.Mysql.UserAuth.Domain
{
    [Table("user_invite_bonus")]
    public class UserInviteBonus
    {
        public string id { get; set; }

        public string username { get; set; }

        public string invite_username { get; set; }

        public decimal deposit { get; set; }

        public DateTime date { get; set; }

        public DateTime create_time { get; set; }

        public string formula { get; set; }
    }
}
