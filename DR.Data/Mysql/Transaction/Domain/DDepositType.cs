using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DR.Data.Mysql.Transaction.Domain
{
    [Table("d_deposit_type")]
    public class DDepositType
    {
        /// <summary>
        ///
        /// <summary>
        public string id { get; set; }
        /// <summary>
        ///创建时间
        /// <summary>
        public DateTime createdate { get; set; }
        /// <summary>
        ///创建人
        /// <summary>
        public string createdby { get; set; }
        /// <summary>
        ///修改时间
        /// <summary>
        public DateTime updatedate { get; set; }
        /// <summary>
        ///修改人
        /// <summary>
        public string updatedby { get; set; }
        /// <summary>
        ///版本
        /// <summary>
        public string rowversion { get; set; }
        /// <summary>
        ///通道名称
        /// <summary>
        public string name { get; set; }
        /// <summary>
        ///状态 0 正常 1关闭
        /// <summary>
        public int status { get; set; }
        /// <summary>
        ///商户号id
        /// <summary>
        public string merchantid { get; set; }
        /// <summary>
        ///最小金额
        /// <summary>
        public decimal mindepositamount { get; set; }
        /// <summary>
        ///最大金额
        /// <summary>
        public decimal maxdepositamount { get; set; }
        /// <summary>
        ///是否用户输入金额 0 支持 1 不支持
        /// <summary>
        public int isinput { get; set; }
        /// <summary>
        ///是否随机数 0 支持 1 不支持
        /// <summary>
        public int issuportrandom { get; set; }
        /// <summary>
        ///手续费 100 为基数
        /// <summary>
        public int bearfee { get; set; }
        /// <summary>
        ///汇率
        /// <summary>
        public decimal feerate { get; set; }
        /// <summary>
        ///0 支持所有 1只支持整数，2支持小数 
        /// <summary>
        public int issuportfixedAmount { get; set; }
        /// <summary>
        ///如果第三方是固定金额 10,30,50  
        /// <summary>
        public string fixedamount { get; set; }
        /// <summary>
        ///该通道所属支付详细id
        /// <summary>
        public string pay_detail_type_id { get; set; }
        /// <summary>
        ///所属在线支付时，选择的银行
        /// <summary>
        public string pay_bank { get; set; }
        /// <summary>
        ///pc,h5.app
        /// <summary>
        public int terminaltype { get; set; }
        /// <summary>
        ///支付类型 ：网银快捷支付，银联扫码，网银在线支付，网银人工到账
        /// <summary>
        public int depositcode { get; set; }
        /// <summary>
        ///所属用户组  多个用户组用逗号隔开
        /// <summary>
        public string usergroup { get; set; }
        /// <summary>
        ///商户详细json信息
        /// <summary>
        public string merchandetailjson { get; set; }
        /// <summary>
        ///回调相对路径
        /// <summary>
        public string notifyurl { get; set; }
        /// <summary>
        ///支付通过type_code 判断走 
        /// <summary>
        public string type_code { get; set; }
        /// <summary>
        ///1 html 2 qrcode  3url 4 form
        /// <summary>
        public int pay_show_type { get; set; }
        /// <summary>
        ///1 第三方支付 2 第三方转账 3第三方代付
        /// <summary>
        public int big_type { get; set; }
        /// <summary>
        ///所属站点
        /// <summary>
        public string zhandian { get; set; }
        /// <summary>
        ///英文名称
        /// <summary>
        public string en_name { get; set; }
        /// <summary>
        ///二维码
        /// <summary>
        public string qr_imageurl { get; set; }
        /// <summary>
        ///是否是测试 0 否 1是 如果是测试，只有能测试账户使用
        /// <summary>
        public int is_test { get; set; }
        /// <summary>
        ///支持的图片 用 | 符号隔开
        /// <summary>
        public string support_apps_images { get; set; }
        /// <summary>
        ///默认1.0
        /// <summary>
        public string version { get; set; }
        /// <summary>
        ///支持国家
        /// <summary>
        public string country { get; set; }
        /// <summary>
        ///支持等级
        /// <summary>
        public string level { get; set; }
        /// <summary>
        ///支付APP
        /// <summary>
        public string support_app { get; set; }
        /// <summary>
        ///每天开始时间
        /// <summary>
        public string start_time { get; set; }
        /// <summary>
        ///每天结束时间
        /// <summary>
        public string end_time { get; set; }
        /// <summary>
        ///每天额度
        /// <summary>
        public decimal daily_total { get; set; }
        /// <summary>
        ///权重值
        /// <summary>
        public int weight_factor { get; set; }
        /// <summary>
        ///排序
        /// <summary>
        public int sort { get; set; }
        /// <summary>
        ///今日已收款
        /// <summary>
        public decimal today_paid { get; set; }
        /// <summary>
        ///
        /// <summary>
        public int auto_withdrawal { get; set; }
        /// <summary>
        ///提款自动支付金额
        /// <summary>
        public decimal today_auto_paid { get; set; }
        /// <summary>
        ///当地址存在时，使用单独的请求地址
        /// <summary>
        public string request_url { get; set; }
        /// <summary>
        ///回调domain
        /// <summary>
        public string notify_domain { get; set; }
        /// <summary>
        ///分发域名,特殊支付使用
        /// <summary>
        public string redirect_url { get; set; }
        /// <summary>
        ///计划任务url
        /// <summary>
        public string schedule_url { get; set; }
        /// <summary>
        ///白名单
        /// <summary>
        public string whiteips { get; set; }
        /// <summary>
        ///merchantid
        /// <summary>
        public string cid { get; set; }
    }
}
