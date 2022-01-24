using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DR.Data.Mysql.Activity.Domain
{
    [Table("hot_game")]
    public class HotGame
    {
        /// <summary>
        ///
        /// <summary>
        public string id { get; set; }
        /// <summary>
        ///
        /// <summary>
        public int sort { get; set; }
        /// <summary>
        ///
        /// <summary>
        public DateTime date { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string create_by { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string update_by { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string main_name { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string main_score { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string main_image { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string league_name { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string away_name { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string away_score { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string away_image { get; set; }
        /// <summary>
        ///
        /// <summary>
        public DateTime update_time { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string category_code { get; set; }
        /// <summary>
        ///
        /// <summary>
        public DateTime show_timestart { get; set; }
        /// <summary>
        ///
        /// <summary>
        public DateTime show_timeend { get; set; }
        /// <summary>
        ///
        /// <summary>
        public int plat_code { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string zhandian { get; set; }
        /// <summary>
        ///merchant id
        /// <summary>
        public string cid { get; set; }
    }
}
