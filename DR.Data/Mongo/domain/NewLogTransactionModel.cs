using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DR.Data.Mongo.domain
{
    [BsonIgnoreExtraElements]
    public class NewLogTransactionModel1
    {

        /// <summary>
        /// 主键
        /// </summary>
        public string _id { get; set; }

        /// <summary>
        /// 交易Code值
        /// </summary>
        public string TransactionCode { get; set; } = "";

        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; } = "";

        /// <summary>
        /// 推荐人
        /// </summary>
        public string Recommend { get; set; } = "";

        /// <summary>
        /// 平台CODE值
        /// </summary>
        public string PlatCode { get; set; } = "";

        /// <summary>
        /// 平台名称
        /// </summary>
        public string PlatName { get; set; } = "";

        /// <summary>
        /// 币种
        /// </summary>
        public string Currency { get; set; } = "";

        /// <summary>
        /// 创建时间
        /// </summary>
        public long CreateTime { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        public long UpdateTime { get; set; }

        /// <summary>
        /// 下注金额
        /// </summary>
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal BetAmount { get; set; }

        /// <summary>
        /// 赢取金额 等于下注加上已赢取部分
        /// </summary>
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal WinAmount { get; set; }

        /// <summary>
        /// 投资有效金额
        /// </summary>
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal TzAmount { get; set; }

        /// <summary>
        /// 有效的下注金额
        /// </summary>
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal EffectiveBetAmount { get; set; }

        /// <summary>
        /// 无效的下注金额
        /// </summary>
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal InvalidBetAmount { get; set; }

        /// <summary>
        /// 游戏下注时间
        /// </summary>
        public long GameBetTime { get; set; }

        /// <summary>
        /// 派彩时间
        /// </summary>
        public long GameUpdateTime { get; set; }

        /// <summary>
        /// 游戏状态
        /// </summary>
        public string GameStatus { get; set; } = "";

        /// <summary>
        /// 1 有效  0 无效 游戏
        /// </summary>
        public string ValidGame { get; set; } = "";

        /// <summary>
        ///SLOT, //老虎机
        ///FISH, //捕鱼
        ///LIVE,  //真人
        ///SPORTS, //体育
        ///LOTTERY, //彩票
        ///CHESS,//棋牌
        /// </summary>
        public string GameType { get; set; } = "";

        /// <summary>
        /// 游戏名
        /// </summary>
        public string GameName { get; set; } = "";

        /// <summary>
        /// 游戏中文名
        /// </summary>
        public string GameNameCN { get; set; } = "";

        /// <summary>
        /// 详细json数据
        /// </summary>
        public string DetailJson { get; set; } = "";

        /// <summary>
        /// 玩家使用平台 web mobile 等
        /// </summary>
        public string PlatForm { get; set; } = "";

        /// <summary>
        /// 状态 1 未结算 2 已结算
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// 用于过期时间
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// 赔率
        /// </summary>
        public string Odds { get; set; }

        /// <summary>
        /// 下注类型
        /// </summary>
        public string BetType { get; set; }

        /// <summary>
        /// 存送无效流水
        /// </summary>
        public string Remark { get; set; }

        public string Zhandian { get; set; } = "";

        /// <summary>
        /// 关联主Code值
        /// </summary>
        public string GlCode { get; set; }

        public int Dateymd { get; set; }


    }
}
