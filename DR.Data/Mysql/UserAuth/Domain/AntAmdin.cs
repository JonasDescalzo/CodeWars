using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DR.Data.Mysql.UserAuth.Domain
{
    [Table("ant_admin")]
    public class AntAmdin
    {
        /// <summary>
        ///主键
        /// <summary>
        public string id { get; set; }
        /// <summary>
        ///代理商编码
        /// <summary>
        public string agent_code { get; set; }
        /// <summary>
        ///代理商名字
        /// <summary>
        public string agent_name { get; set; }
        /// <summary>
        ///0正常 1 冻结
        /// <summary>
        public int status { get; set; }
        /// <summary>
        ///0正常 1被删除
        /// <summary>
        public int is_delete { get; set; }
        /// <summary>
        ///创建时间
        /// <summary>
        public DateTime create_time { get; set; }
        /// <summary>
        ///更新时间
        /// <summary>
        public DateTime update_time { get; set; }
        /// <summary>
        ///代理绑定用户主账号
        /// <summary>
        public string main_account { get; set; }
        /// <summary>
        ///代理前缀
        /// <summary>
        public string prefix { get; set; }
        /// <summary>
        ///merchantid
        /// <summary>
        public string cid { get; set; }
    }
}
