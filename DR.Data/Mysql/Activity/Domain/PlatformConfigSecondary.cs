using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DR.Data.Mysql.Activity.Domain
{
    [Table("platform_config_secondary")]
    public class PlatformConfigSecondary
    {
        /// <summary>
        ///id
        /// <summary>
        public string id { get; set; }
        /// <summary>
        ///platform config id
        /// <summary>
        public string platform_id { get; set; }
        /// <summary>
        ///default is 1, 0 not usable, 1 usable
        /// <summary>
        public int is_usable { get; set; }
        /// <summary>
        ///Platform status 0 Normal 1 Maintenance
        /// <summary>
        public int plat_status { get; set; }
        /// <summary>
        ///
        /// <summary>
        public int wallet_status { get; set; }
        /// <summary>
        ///image url UI
        /// <summary>
        public string image_url { get; set; }
        /// <summary>
        ///image url UI
        /// <summary>
        public string pc_image_url { get; set; }
        /// <summary>
        ///
        /// <summary>
        public int sort_no { get; set; }
        /// <summary>
        ///merchant id
        /// <summary>
        public string cid { get; set; }
        /// <summary>
        ///platcode
        /// <summary>
        public int platform_code { get; set; }
        /// <summary>
        ///plat name
        /// <summary>
        public string platform_name { get; set; }
        /// <summary>
        ///en name
        /// <summary>
        public string en_name { get; set; }
        /// <summary>
        ///is slot machine
        /// <summary>
        public int is_slot { get; set; }
        /// <summary>
        ///wallet type
        /// <summary>
        public int wallet_type { get; set; }
    }
}
