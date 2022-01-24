using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DR.Data.Mongo.domain
{
    [BsonIgnoreExtraElements]
    public class UserNeedBill
    {
        public string _id { get; set; }

        public string UserName { get; set; }

        /// <summary>
        /// 需要的普通流水
        /// </summary>
        public decimal NeedGameBill { get; set; }

        /// <summary>
        /// 需要的体育流水
        /// </summary>
        public decimal NeedSportsBill { get; set; }

        /// <summary>
        /// 需要的普通流水
        /// </summary>
        public decimal NeedBonusGameBill { get; set; }

        /// <summary>
        /// 需要的体育流水
        /// </summary>
        public decimal NeedBonusSportsBill { get; set; }

        /// <summary>
        /// 时间戳
        /// </summary>
        public DateTime Date { get; set; }

        public long CreateTime { get; set; }

        public long UpdateTime { get; set; }

        /// <summary>
        /// 使用json 替换原有的bill
        /// </summary>
        public string GameBillDetailInfo { get; set; }
    }
}
