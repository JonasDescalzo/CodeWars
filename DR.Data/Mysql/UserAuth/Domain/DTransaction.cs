using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DR.Data.Mysql.UserAuth.Domain
{
    [Table("d_transaction")]
    public class DTransaction
    {
        /// <summary>
        ///
        /// <summary>
        public string id { get; set; }
        /// <summary>
        ///订单号
        /// <summary>
        public string order_id { get; set; }
        /// <summary>
        ///用户名
        /// <summary>
        public string username { get; set; }
        /// <summary>
        ///类型  1 游戏交易  2充值交易  3提款交易 4 活动  5 银行卡转账 6扣款
        /// <summary>
        public int type { get; set; }
        /// <summary>
        ///详细类型 11 游戏转出  12 游戏转入 21 充值pengding 22 fail 23success  31 提款 申请中 32 审核成功 33 审核失败 34 已支付 34 已支付 success  41 奖金pengding 42 fail 43success
        /// <summary>
        public int type_detail { get; set; }
        /// <summary>
        ///交易到账金额
        /// <summary>
        public decimal amount { get; set; }
        /// <summary>
        ///手续费
        /// <summary>
        public decimal fee { get; set; }
        /// <summary>
        ///所属推广者账号
        /// <summary>
        public string recommend { get; set; }
        /// <summary>
        ///交易前金额
        /// <summary>
        public decimal balance_before { get; set; }
        /// <summary>
        ///交易后金额
        /// <summary>
        public decimal balance_after { get; set; }
        /// <summary>
        ///如果是第三方交易 第三方交易通道id
        /// <summary>
        public string pay_providerid { get; set; }
        /// <summary>
        ///创建者
        /// <summary>
        public string create_by { get; set; }
        /// <summary>
        ///更新者
        /// <summary>
        public string update_by { get; set; }
        /// <summary>
        ///创建时间
        /// <summary>
        public DateTime create_time { get; set; }
        /// <summary>
        ///更新时间
        /// <summary>
        public DateTime update_time { get; set; }
        /// <summary>
        ///转自id
        /// <summary>
        public int fromplatcode { get; set; }
        /// <summary>
        ///被转入平台id
        /// <summary>
        public string toplatcode { get; set; }
        /// <summary>
        ///用户备注
        /// <summary>
        public string remark { get; set; }
        /// <summary>
        ///订单名称
        /// <summary>
        public string transaction_name { get; set; }
        /// <summary>
        ///银行名称  
        /// <summary>
        public string bank_name { get; set; }
        /// <summary>
        ///银行卡号
        /// <summary>
        public string bank_number { get; set; }
        /// <summary>
        ///持卡人姓名
        /// <summary>
        public string real_name { get; set; }
        /// <summary>
        ///手续费百分比，最小0
        /// <summary>
        public string fee_percentage { get; set; }
        /// <summary>
        ///实际需要添加金额
        /// <summary>
        public decimal amount_transaction { get; set; }
        /// <summary>
        ///支付转账方式
        /// <summary>
        public string pay_type { get; set; }
        /// <summary>
        ///活动id
        /// <summary>
        public string activity_id { get; set; }
        /// <summary>
        ///1 用户提款  2代理商提款
        /// <summary>
        public string withdrawal_type { get; set; }
        /// <summary>
        ///后台备注
        /// <summary>
        public string system_remark { get; set; }
        /// <summary>
        ///充值时的随机金额
        /// <summary>
        public decimal random_amount { get; set; }
        /// <summary>
        ///第三方交易时的请求数据
        /// <summary>
        public string transaction_json { get; set; }
        /// <summary>
        ///省
        /// <summary>
        public string province { get; set; }
        /// <summary>
        ///市
        /// <summary>
        public string city { get; set; }
        /// <summary>
        ///该订单付款时参与的活动id
        /// <summary>
        public string pay_activity_id { get; set; }
        /// <summary>
        ///0 第三方自动到账  1 手动到账
        /// <summary>
        public string bank_type { get; set; }
        /// <summary>
        ///倍率
        /// <summary>
        public string beilv { get; set; }
        /// <summary>
        ///是否代充
        /// <summary>
        public int daichong { get; set; }
        /// <summary>
        ///改订单所属站点
        /// <summary>
        public string zhandian { get; set; }
        /// <summary>
        ///印度的ifsc
        /// <summary>
        public string bank_ifsc { get; set; }
        /// <summary>
        ///第三方返回的id
        /// <summary>
        public string third_orderid { get; set; }
        /// <summary>
        ///模拟号码
        /// <summary>
        public string fake_number { get; set; }
        /// <summary>
        ///所属员工
        /// <summary>
        public string uagent { get; set; }
        /// <summary>
        ///0 普通 1 自动出款   只要进入自动流程就算自动出款
        /// <summary>
        public int? auto_work { get; set; }
        /// <summary>
        ///标记 自动出款专用标记
        /// <summary>
        public string mark { get; set; }
        /// <summary>
        ///用户提交金额
        /// <summary>
        public decimal submit_amount { get; set; }
        /// <summary>
        ///特殊标记
        /// <summary>
        public int sp_bj { get; set; }
        /// <summary>
        ///app version
        /// <summary>
        public string version { get; set; }
        /// <summary>
        ///忽略amount
        /// <summary>
        public decimal? gl_amount { get; set; }
        /// <summary>
        ///国家代码
        /// <summary>
        public string country_code { get; set; }
        /// <summary>
        ///currency used for transaction
        /// <summary>
        public string currency { get; set; }
        /// <summary>
        ///amount to usd d4
        /// <summary>
        public decimal? amount_to_usd_d4 { get; set; }
        /// <summary>
        ///amount to usd
        /// <summary>
        public string amount_to_usd_rate { get; set; }

        public int? @checked { get; set; }

        /// <summary>
        ///cid
        /// <summary>
        public string cid { get; set; }

        public int gmt { get; set; }
    }
}
