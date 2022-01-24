using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DR.Data.Mysql.Activity.Domain
{
    [Table("line_game_assocition")]
    public class LineGameAssocition
    {
        /// <summary>
        ///唯一ID
        /// <summary>
        public string id { get; set; }
        /// <summary>
        ///线路ID
        /// <summary>
        public string line_id { get; set; }
        /// <summary>
        ///游戏ID
        /// <summary>
        public string game_id { get; set; }
        /// <summary>
        ///游戏图片-pc
        /// <summary>
        public string image_src_pc { get; set; }
        /// <summary>
        ///游戏图片-app
        /// <summary>
        public string image_src_app { get; set; }
        /// <summary>
        ///游戏描述
        /// <summary>
        public string game_desc { get; set; }
        /// <summary>
        ///是否可用, 默认为1。 0：否；1：是
        /// <summary>
        public int is_usable { get; set; }
        /// <summary>
        ///排序编号(后台获取最大sort_no + 1)
        /// <summary>
        public int sort_no { get; set; }
    }
}
