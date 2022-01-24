using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DR.Data.Mysql.Activity.Domain
{
    [Table("game_config_idependent")]
    public class GameConfigIdependent
    {
        /// <summary>
        ///
        /// <summary>
        public string id { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string game_id { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string name_cn { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string name_en { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string image_src_pc { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string image_src_app { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string is_usable { get; set; }
        /// <summary>
        ///
        /// <summary>
        public int sort_no { get; set; }
        /// <summary>
        ///
        /// <summary>
        public int is_recommend { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string cid { get; set; }
    }
}
