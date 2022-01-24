using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DR.Data.Mysql.UserAuth.Domain
{
    [Table("aff_wallet")]
    public class AffWallet
    {
        /// <summary>
        ///
        /// <summary>
        public string id { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string wallet_name { get; set; }
        /// <summary>
        ///Unknown attribute 1
        /// <summary>
        public string ex1 { get; set; }
        /// <summary>
        ///Unknown attribute 2
        /// <summary>
        public string ex2 { get; set; }
        /// <summary>
        ///Unknown attribute 3
        /// <summary>
        public string ex3 { get; set; }
        /// <summary>
        ///Unknown attribute 4
        /// <summary>
        public string ex4 { get; set; }
        /// <summary>
        ///Unknown attribute 5
        /// <summary>
        public string ex5 { get; set; }
        /// <summary>
        ///Unknown attribute 6
        /// <summary>
        public string ex6 { get; set; }
        /// <summary>
        ///
        /// <summary>
        public DateTime create_time { get; set; }
        /// <summary>
        ///
        /// <summary>
        public DateTime update_time { get; set; }
        /// <summary>
        ///Associated with AFF
        /// <summary>
        public string aff_username { get; set; }
    }
}
