using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DR.Data.Mongo.domain
{
    [BsonIgnoreExtraElements]
    public class PayOrderModel
    {
        public string _id { get; set; }

        /// <summary>
        /// 请求路径 通过路径判断是哪个支付
        /// </summary>
        public string NotifyUrl { get; set; }

        /// <summary>
        /// 请求参数
        /// </summary>
        public string Request { get; set; }

        /// <summary>
        /// 时间
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// 返回类型 1 请求第三方支付   2 是第三方回调   3 请求第三方代付  4第三方请求转账
        /// </summary>
        public int ResultType { get; set; }

        /// <summary>
        /// 第三方返回
        /// </summary>
        public string ThirdResponse { get; set; }

        /// <summary>
        /// 返回参数
        /// </summary>
        public string Response { get; set; }

        /// <summary>
        /// 返回状态
        /// </summary>
        public int StatusCode { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public long CreateTime { get; set; }
    }
}
