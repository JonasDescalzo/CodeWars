using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DR.Data.Mysql.UserAuth.Domain
{
    [Table("aff")]
    public class Aff
    {
        /// <summary>
        ///主键
        /// <summary>
        public string id { get; set; }
        /// <summary>
        ///绑定管理员用户名
        /// <summary>
        public string username { get; set; }
        /// <summary>
        ///推广代理推广码
        /// <summary>
        public string aff_recommand { get; set; }
        /// <summary>
        ///推广真实姓名可以为代号
        /// <summary>
        public string aff_realname { get; set; }
        /// <summary>
        ///提成百分比
        /// <summary>
        public string aff_withdrawal_layering { get; set; }
        /// <summary>
        ///创建时间
        /// <summary>
        public DateTime create_time { get; set; }
        /// <summary>
        ///返利用户绑定代理商
        /// <summary>
        public string agent_code { get; set; }
        /// <summary>
        ///0 正常 1被冻结  2审核中
        /// <summary>
        public int status { get; set; }
        /// <summary>
        ///手机号
        /// <summary>
        public string phone { get; set; }
        /// <summary>
        ///余额
        /// <summary>
        public decimal amount { get; set; }
        /// <summary>
        ///锁定金额
        /// <summary>
        public decimal lock_amout { get; set; }
        /// <summary>
        ///密码
        /// <summary>
        public string password { get; set; }
        /// <summary>
        ///交易密码
        /// <summary>
        public string trans_password { get; set; }
        /// <summary>
        ///上级代理
        /// <summary>
        public string parent_aff { get; set; }
        /// <summary>
        ///平台手续费
        /// <summary>
        public decimal plat_money_fee { get; set; }
        /// <summary>
        ///存提手续费
        /// <summary>
        public decimal dw_money_fee { get; set; }
        /// <summary>
        ///最后扎帐时间
        /// <summary>
        public DateTime last_up_time { get; set; }
        /// <summary>
        ///微信号
        /// <summary>
        public string wx { get; set; }
        /// <summary>
        ///小飞机
        /// <summary>
        public string telegram { get; set; }
        /// <summary>
        ///0 普通 1可信
        /// <summary>
        public int is_good { get; set; }
        /// <summary>
        ///其它平台手续费
        /// <summary>
        public decimal plat_other_money_fee { get; set; }
        /// <summary>
        ///0 不可代充  1可代充
        /// <summary>
        public int is_daichong { get; set; }
        /// <summary>
        ///代充剩余额度
        /// <summary>
        public decimal daichong_amount { get; set; }
        /// <summary>
        ///代充赠送比例 万分之
        /// <summary>
        public int daichong_bl { get; set; }
        /// <summary>
        ///站点
        /// <summary>
        public string zhandian { get; set; }
        /// <summary>
        ///0 负盈利  1 净注册(只适用于印度市场)
        /// <summary>
        public int commistion_type { get; set; }
        /// <summary>
        ///注册派发金额数
        /// <summary>
        public decimal register_amount { get; set; }
        /// <summary>
        ///存款派发金额数
        /// <summary>
        public decimal deposit_amount { get; set; }
        /// <summary>
        ///适用于海外站
        /// <summary>
        public string whatsup { get; set; }
        /// <summary>
        ///skype
        /// <summary>
        public string skype { get; set; }
        /// <summary>
        ///email
        /// <summary>
        public string email { get; set; }
        /// <summary>
        ///改代理用户注册送余额
        /// <summary>
        public decimal user_register_amount { get; set; }
        /// <summary>
        ///所属员工
        /// <summary>
        public string uagent { get; set; }
        /// <summary>
        ///注册送余额时添加的流水
        /// <summary>
        public decimal user_register_rollover { get; set; }
        /// <summary>
        ///最小取款额度
        /// <summary>
        public decimal withdrawal_min { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string witehdrawal { get; set; }
        /// <summary>
        ///merchantid
        /// <summary>
        public string cid { get; set; }
    }
}
