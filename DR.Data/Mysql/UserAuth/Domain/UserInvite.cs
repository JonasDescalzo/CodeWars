using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DR.Data.Mysql.UserAuth.Domain
{
    [Table("user_invite")]
    public class UserInvite
    {
        /// <summary>
        ///
        /// <summary>
        public string id { get; set; }
        /// <summary>
        ///邀请人账号
        /// <summary>
        public string invite_user { get; set; }
        /// <summary>
        ///被邀请人账号
        /// <summary>
        public string invitees_user { get; set; }
        /// <summary>
        ///被邀请人手机号
        /// <summary>
        public string invitees_phone { get; set; }
        /// <summary>
        ///0 未审核  1 已通过  2 审核失败
        /// <summary>
        public int status { get; set; }
        /// <summary>
        ///邀请人ip
        /// <summary>
        public string invite_ip { get; set; }
        /// <summary>
        ///奖励金额
        /// <summary>
        public decimal money { get; set; }
        /// <summary>
        ///创建时间
        /// <summary>
        public DateTime create_time { get; set; }
    }
}
