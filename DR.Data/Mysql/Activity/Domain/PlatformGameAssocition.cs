using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DR.Data.Mysql.Activity.Domain
{
    [Table("platform_game_assocition")]
    public class PlatformGameAssocition
    {
        /// <summary>
        ///唯一ID
        /// <summary>
        public string id { get; set; }
        /// <summary>
        ///平台ID
        /// <summary>
        public string platform_id { get; set; }
        /// <summary>
        ///游戏ID
        /// <summary>
        public string game_id { get; set; }
        /// <summary>
        ///是否可用, 默认为1。 0：否；1：是
        /// <summary>
        public int is_usable { get; set; }
    }
}
