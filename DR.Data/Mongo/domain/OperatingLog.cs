using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DR.Data.Mongo.domain
{
    [BsonIgnoreExtraElements]
    public class OperatingLog
    {
        /// <summary>
        /// 主键
        /// </summary>
        public string _id { get; set; }

        /// <summary>
        /// 日志类型
        /// </summary>
        public string TypeCode { get; set; }

        /// <summary>
        /// 匹配类型的操作id
        /// </summary>
        public string LogOperatingId { get; set; }

        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// 添加的unix 时间戳
        /// </summary>
        public long CreateUnixTime { get; set; }

        /// <summary>
        /// 操作者
        /// </summary>
        public string CreateBy { get; set; }

        /// <summary>
        /// 日志类型
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 日志扩展字段
        /// </summary>
        public string Ex1 { get; set; }

        /// <summary>
        /// 日志扩展字段
        /// </summary>
        public string Ex2 { get; set; }

        /// <summary>
        /// 日志扩展字段
        /// </summary>
        public string Ex3 { get; set; }

        /// <summary>
        /// 日志扩展字段
        /// </summary>
        public string Ex4 { get; set; }

        /// <summary>
        /// 日志扩展字段
        /// </summary>
        public string Ex5 { get; set; }

        /// <summary>
        /// 日志扩展字段
        /// </summary>
        public string Ex6 { get; set; }

        /// <summary>
        /// 日志扩展字段
        /// </summary>
        public string Ex7 { get; set; }

    }
}
