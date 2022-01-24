using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DR.Data.Mysql.UserAuth.Domain
{
    [Table("user_rank")]
    public class UserRank
    {
        /// <summary>
        ///Id
        /// <summary>
        public string id { get; set; }
        /// <summary>
        ///Username
        /// <summary>
        public string username { get; set; }
        /// <summary>
        ///User Nickname
        /// <summary>
        public string nickname { get; set; }
        /// <summary>
        ///Win Amount
        /// <summary>
        public decimal profit_margin { get; set; }
        /// <summary>
        ///Play Count
        /// <summary>
        public int sessions { get; set; }
        /// <summary>
        ///Update Time
        /// <summary>
        public DateTime update_time { get; set; }
        /// <summary>
        ///Rank Number
        /// <summary>
        public int rank { get; set; }
        /// <summary>
        ///cid
        /// <summary>
        public string cid { get; set; }
    }
}
