using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DR.Data.Mysql.Activity.Domain
{
    [Table("notice")]
    public class Notice
    {
        /// <summary>
        ///
        /// <summary>
        public string id { get; set; }
        /// <summary>
        ///消息
        /// <summary>
        public string message { get; set; }
        /// <summary>
        ///创建时间
        /// <summary>
        public DateTime create_time { get; set; }
        /// <summary>
        ///排序
        /// <summary>
        public int sort { get; set; }
        /// <summary>
        ///url 链接
        /// <summary>
        public string url { get; set; }
        /// <summary>
        ///0 正常 1 禁止
        /// <summary>
        public int status { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string zhandian { get; set; }
        /// <summary>
        ///merchantid
        /// <summary>
        public string cid { get; set; }
    }
}
