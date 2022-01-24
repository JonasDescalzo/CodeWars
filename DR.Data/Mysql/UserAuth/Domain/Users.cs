using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DR.Data.Mysql.UserAuth.Domain
{
    [Table("users")]
    public class Users
    {
        /// <summary>
        ///
        /// <summary>
        public string id { get; set; }
        /// <summary>
        ///用户名
        /// <summary>
        public string name { get; set; }
        /// <summary>
        ///昵称
        /// <summary>
        public string nickname { get; set; }
        /// <summary>
        ///0 正常  1被禁用
        /// <summary>
        public int status { get; set; }
        /// <summary>
        ///用户头像
        /// <summary>
        public string icon { get; set; }
        /// <summary>
        ///创建时间
        /// <summary>
        public DateTime create_time { get; set; }
        /// <summary>
        ///更新时间
        /// <summary>
        public DateTime update_time { get; set; }
        /// <summary>
        ///MD5密码
        /// <summary>
        public string password { get; set; }
        /// <summary>
        ///用户类型 1 后端管理员  2 网站会员
        /// <summary>
        public int type { get; set; }
        /// <summary>
        ///1 被删除 0 正常
        /// <summary>
        public int is_delete { get; set; }
        /// <summary>
        ///用户电话
        /// <summary>
        public string phone { get; set; }
        /// <summary>
        ///邮件
        /// <summary>
        public string email { get; set; }
        /// <summary>
        ///供应商code值
        /// <summary>
        public string agent_code { get; set; }
        /// <summary>
        ///推广码，6位唯一
        /// <summary>
        public string recommand { get; set; }
        /// <summary>
        ///用户等级关联id
        /// <summary>
        public string user_level { get; set; }
        /// <summary>
        ///真实姓名
        /// <summary>
        public string real_name { get; set; }
        /// <summary>
        ///性别
        /// <summary>
        public string gender { get; set; }
        /// <summary>
        ///用户微信号
        /// <summary>
        public string wx { get; set; }
        /// <summary>
        ///用户生日
        /// <summary>
        public DateTime birthday { get; set; }
        /// <summary>
        ///最后登录时间
        /// <summary>
        public DateTime lastlogintime { get; set; }
        /// <summary>
        ///最后一次领取反水时间
        /// <summary>
        public DateTime last_receive_wash_code_time { get; set; }
        /// <summary>
        ///用户所在组关联id
        /// <summary>
        public string user_group { get; set; }
        /// <summary>
        ///被推荐人推广码 6位数
        /// <summary>
        public string recommended { get; set; }
        /// <summary>
        ///被推荐人代理码
        /// <summary>
        public string affrecommended { get; set; }
        /// <summary>
        ///国家代码
        /// <summary>
        public string country_code { get; set; }
        /// <summary>
        ///所有存款
        /// <summary>
        public decimal all_deposit { get; set; }
        /// <summary>
        ///所有有效游戏流水
        /// <summary>
        public decimal all_gamebill { get; set; }
        /// <summary>
        ///提现还需游戏流水
        /// <summary>
        public decimal withdrawal_need_gamebill { get; set; }
        /// <summary>
        ///今天已经提现金额
        /// <summary>
        public decimal today_already_amount { get; set; }
        /// <summary>
        ///今天已经提现次数
        /// <summary>
        public int today_amount_count { get; set; }
        /// <summary>
        ///最后存款时间
        /// <summary>
        public DateTime last_deposit_time { get; set; }
        /// <summary>
        ///0 自然用户  1 分享用户  2 是 代理推广用户
        /// <summary>
        public int recommend_type { get; set; }
        /// <summary>
        ///提现还需体育流水
        /// <summary>
        public decimal withdrawal_need_sportsbill { get; set; }
        /// <summary>
        ///1 已经领取体育首存
        /// <summary>
        public int sports_firstdeposit { get; set; }
        /// <summary>
        ///1 当天已经领取  每日凌晨刷新
        /// <summary>
        public int sports_daydeposit { get; set; }
        /// <summary>
        ///1 已领取 当天存送领取标识 每日凌晨刷新
        /// <summary>
        public int sports_lq { get; set; }
        /// <summary>
        ///体育钱包锁金额
        /// <summary>
        public decimal lock_amount { get; set; }
        /// <summary>
        ///0 未领取绑定额度 1 已领取绑定额度
        /// <summary>
        public int lq_bank { get; set; }
        /// <summary>
        ///0 未领取金额  1 已领取金额
        /// <summary>
        public int lq_nickname { get; set; }
        /// <summary>
        ///0 未领取 1 已领取
        /// <summary>
        public int lq_realname { get; set; }
        /// <summary>
        ///0 未派发 1 已派发
        /// <summary>
        public int pf_recommended_reward { get; set; }
        /// <summary>
        ///0 普通 1OK
        /// <summary>
        public int is_good { get; set; }
        /// <summary>
        ///多倍流水
        /// <summary>
        public decimal withdrawal_need_many_sportsbill { get; set; }
        /// <summary>
        ///1 已经领取老虎机首存
        /// <summary>
        public int tiger_firstdeposit { get; set; }
        /// <summary>
        ///所属国家站点
        /// <summary>
        public string zhandian { get; set; }
        /// <summary>
        ///0正常 1 禁用转账
        /// <summary>
        public int isdisabletransfer { get; set; }
        /// <summary>
        ///支援金最后领取时间
        /// <summary>
        public DateTime last_subsidy_time { get; set; }
        /// <summary>
        ///英文 firstname
        /// <summary>
        public string first_name { get; set; }
        /// <summary>
        ///英文lastname
        /// <summary>
        public string last_name { get; set; }
        /// <summary>
        ///pancard 路径
        /// <summary>
        public string pancard_imgurl { get; set; }
        /// <summary>
        ///0 不需要pancard 1 需要pancard
        /// <summary>
        public int isneed_pancard { get; set; }
        /// <summary>
        ///0 OK 1 审核
        /// <summary>
        public int pancard_ok { get; set; }
        /// <summary>
        ///是哪个domain 注册的
        /// <summary>
        public string domain { get; set; }
        /// <summary>
        ///是否是测试者0 否 1是
        /// <summary>
        public int is_test { get; set; }
        /// <summary>
        ///推广广告ID 用户S2S等等
        /// <summary>
        public string tgid { get; set; }
        /// <summary>
        ///邀请用户每存款X,奖励Y
        /// <summary>
        public string invite_user_deposit_bonus { get; set; }
        /// <summary>
        ///邀请用户第一次存款奖励金额
        /// <summary>
        public decimal invite_user_ftd_bonus { get; set; }
        /// <summary>
        ///1 已经领取真人首存
        /// <summary>
        public int live_firstdeposit { get; set; }
        /// <summary>
        ///剩余的每日奖励次数
        /// <summary>
        public int daily_bonus_int { get; set; }
        /// <summary>
        ///单个用户每天取款次数默认1，与等级count 共同控制，以最高为准
        /// <summary>
        public int daily_withdrawal_count { get; set; }
        /// <summary>
        ///所属agent
        /// <summary>
        public string uagent { get; set; }
        /// <summary>
        ///remark
        /// <summary>
        public string remark { get; set; }
        /// <summary>
        ///是否可以自动取款  0 自动   1非自动
        /// <summary>
        public int auto_withdrawal { get; set; }
        /// <summary>
        ///第一次存款金额
        /// <summary>
        public decimal first_deposit { get; set; }
        /// <summary>
        ///最后一次上传时间
        /// <summary>
        public DateTime last_upload_picture { get; set; }
        /// <summary>
        ///2个组别
        /// <summary>
        public int exchange_group { get; set; }
        /// <summary>
        ///用户google云信息token
        /// <summary>
        public string firebase_message_token { get; set; }
        /// <summary>
        ///登录过的version
        /// <summary>
        public string version { get; set; }
        /// <summary>
        ///cid
        /// <summary>
        public string cid { get; set; }
    }
}
