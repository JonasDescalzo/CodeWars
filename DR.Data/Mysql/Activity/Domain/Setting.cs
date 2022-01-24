using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DR.Data.Mysql.Activity.Domain
{
    [Table("setting")]
    public class Setting
    {
        /// <summary>
        ///
        /// <summary>
        public string Id { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string key_code { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string value { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string name { get; set; }
        /// <summary>
        ///
        /// <summary>
        public DateTime create_time { get; set; }
        /// <summary>
        ///
        /// <summary>
        public DateTime update_time { get; set; }
        /// <summary>
        ///所属代理商
        /// <summary>
        public string agent_code { get; set; }
        /// <summary>
        ///1 展示 0 不展示
        /// <summary>
        public int show { get; set; }
    }
}
