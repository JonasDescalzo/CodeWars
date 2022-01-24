using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DR.Data.Mysql.UserAuth.Domain
{
    [Table("users_station_letter")]
    public class UsersStationLetter
    {
        /// <summary>
        ///
        /// <summary>
        public string id { get; set; }
        /// <summary>
        ///发送类型 1 全部   2对应单个用户
        /// <summary>
        public int type { get; set; }
        /// <summary>
        ///当对应单个用户时 用户名
        /// <summary>
        public string user_name { get; set; }
        /// <summary>
        ///消息体
        /// <summary>
        public string content { get; set; }
        /// <summary>
        ///消息标题
        /// <summary>
        public string title { get; set; }
        /// <summary>
        ///创建时间
        /// <summary>
        public DateTime create_time { get; set; }
        /// <summary>
        ///是否被删除 0 正常  1被删除
        /// <summary>
        public int is_delete { get; set; }
        /// <summary>
        ///所属站点
        /// <summary>
        public string zhandian { get; set; }
    }
}
