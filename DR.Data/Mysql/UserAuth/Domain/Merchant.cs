using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DR.Data.Mysql.UserAuth.Domain
{
    [Table("merchant")]
    public class Merchant
    {
        /// <summary>
        ///
        /// <summary>
        public string id { get; set; }
        /// <summary>
        ///商户名称
        /// <summary>
        public string username { get; set; }
        /// <summary>
        ///创建时间
        /// <summary>
        public DateTime create_time { get; set; }
        /// <summary>
        ///1 ok 0 close
        /// <summary>
        public int status { get; set; }
        /// <summary>
        ///summary date time
        /// <summary>
        public string aff_date_data_time { get; set; }
        /// <summary>
        ///0 all 1 only allow ipv4
        /// <summary>
        public string allow_ip { get; set; }
        /// <summary>
        ///android afl download
        /// <summary>
        public string android_afl { get; set; }
        /// <summary>
        ///android new ANDROID url
        /// <summary>
        public string android_new_downloadurl { get; set; }
        /// <summary>
        ///android package
        /// <summary>
        public string android_package { get; set; }
        /// <summary>
        ///BANK_DEPOSIT
        /// <summary>
        public string bank_deposit { get; set; }
        /// <summary>
        ///COMMON_REWARDS
        /// <summary>
        public string common_rewards { get; set; }
        /// <summary>
        ///DOWNLOAD_JUMP

        /// <summary>
        public string download_jump { get; set; }
        /// <summary>
        ///EXCHANGE_REDIRECT_SWITCH
        /// <summary>
        public string exchange_redirect_switch { get; set; }
        /// <summary>
        ///FIREBASE_DOWNLOAD_LINK
        /// <summary>
        public string firebase_download_link { get; set; }
        /// <summary>
        ///FIREBASE_PAGE_LINK
        /// <summary>
        public string firebase_page_link { get; set; }
        /// <summary>
        ///GOOD_PAY_DEPOSIT
        /// <summary>
        public string good_pay_deposit { get; set; }
        /// <summary>
        ///GOOGLE_SCOR
        /// <summary>
        public string google_scor { get; set; }
        /// <summary>
        ///IMAGE_DOMAIN
        /// <summary>
        public string image_domain { get; set; }
        /// <summary>
        ///INDIA_HTTP_JUMP_DOMAIN
        /// <summary>
        public string india_http_jump_domain { get; set; }
        /// <summary>
        ///INDIA_INVITE_ADDRESS
        /// <summary>
        public string india_invite_address { get; set; }
        /// <summary>
        ///INDIA_JY
        /// <summary>
        public string india_jy { get; set; }
        /// <summary>
        ///INDIA_PAY_DERECTURL
        /// <summary>
        public string india_pay_derecturl { get; set; }
        /// <summary>
        ///INDIA_PAY_DERECTURLV2
        /// <summary>
        public string india_pay_derecturlv2 { get; set; }
        /// <summary>
        ///INDIAANDROID_IOS_APK_AFF_DMOAIN
        /// <summary>
        public string indiaandroid_ios_apk_aff_dmoain { get; set; }
        /// <summary>
        ///INDIAANDROID_NAME
        /// <summary>
        public string indiaandroid_name { get; set; }
        /// <summary>
        ///INDIABANK_DEPOSIT
        /// <summary>
        public string indiabank_deposit { get; set; }
        /// <summary>
        ///INDIADOWNLOAD_ADDRESS
        /// <summary>
        public string indiadownload_address { get; set; }
        /// <summary>
        ///INDIAIOS_URL
        /// <summary>
        public string indiaios_url { get; set; }
        /// <summary>
        ///INDIASPORTS_LS
        /// <summary>
        public string indiasports_ls { get; set; }
        /// <summary>
        ///INDIAWITHDRAWAL_MAX
        /// <summary>
        public string indiawithdrawal_max { get; set; }
        /// <summary>
        ///INDIAWITHDRAWAL_MIN
        /// <summary>
        public string indiawithdrawal_min { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string ios_package { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string ios_plist { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string ip_register_date { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string need_pancard { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string pay_domain { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string register_switch { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string sms_switch { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string user_deposit_bonus { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string user_ftd_bonus { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string userstatistics_time { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string verify_version { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string wash_min_amount { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string wash_total_image { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string withdrawal_max { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string withdrawal_min { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string ios_new_downloadurl { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string download_v2_percent { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string ip_register_date_count { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string india_kf_http_url { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string india_kf_phone_url { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string agent_mobile_address { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string agent_pc_address { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string android_ios_apk_aff_dmoain { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string android_min_live_version { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string android_name { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string android_new_content { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string android_new_version { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string auto_withdrawal_daily_total { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string auto_withdrawal_havedeposit_detail { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string auto_withdrawal_level { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string auto_withdrawal_mode { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string auto_withdrawal_nodeposit_detail { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string auto_withdrawal_rummy_transfer { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string auto_withdrawal_status { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string auto_withdrawal_time_end { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string auto_withdrawal_time_start { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string auto_withdrawal_userneed { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string auto_withdrawal_withdrawal_max { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string auto_withdrawal_withdrawal_min { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string auto_withdrawal_withdrawal_xmultiples { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string bank_deposit_song { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string cashfree_one { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string cashfree_two { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string country_code { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string deposit_amount { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string download_address { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string dw_money_fee { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string firebasemessage_token { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string fx_qr_domain { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string gamebill_time { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string hk_bonus_percent { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string hk_game_percent { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string hk_percent { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string hk_withdrawal_percent { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string http_jump_domain { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string invite_address { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string ios_min_live_version { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string ios_new_content { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string ios_new_version { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string ios_url { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string kf_http_url { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string memeber_app_promotion { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string memeber_mobile_promotion { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string memeber_pc_promotion { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string no_cdn_image_domain { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string pay_derecturl { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string paybill_time { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string plat_money_fee { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string plat_other_money_fee { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string register_amount { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string sports_gamebill_time { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string sports_ls { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string tc_url { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string tc_window { get; set; }
        /// <summary>
        ///agent domain
        /// <summary>
        public string agent_domain { get; set; }
        /// <summary>
        ///account last letter
        /// <summary>
        public string last_letter { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string logo_url { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string brand_name { get; set; }
        /// <summary>
        ///test
        /// <summary>
        public string payment_reminder { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string skype { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string support { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string telegram { get; set; }
        /// <summary>
        ///Used to optimize query speed
        /// <summary>
        public int cid_key { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string aff_login_page { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string aff_register_page { get; set; }
        /// <summary>
        ///
        /// <summary>
        public int sms_type { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string pk_kf_http_url { get; set; }
    }
}
