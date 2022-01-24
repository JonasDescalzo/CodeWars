using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DR.Data.Mysql.Activity.Domain
{
    [Table("game_config")]
    public class GameConfig
    {
        /// <summary>
        /// 游戏Id
        /// </summary> 
 		[Column("id")]
        public string Id { get; set; }

        /// <summary>
        /// 游戏名称_中文
        /// </summary> 
 		[Column("name_cn")]
        public string NameCN { get; set; }

        /// <summary>
        /// 游戏名称_英文
        /// </summary> 
 		[Column("name_en")]
        public string NameEN { get; set; }

        /// <summary>
        /// 游戏代码_PC
        /// </summary> 
 		[Column("game_code_pc")]
        public string GameCodePC { get; set; }

        /// <summary>
        /// 游戏代码_APP
        /// </summary> 
 		[Column("game_code_app")]
        public string GameCodeApp { get; set; }

        /// <summary>
        /// 游戏图片_PC
        /// </summary> 
 		[Column("image_src_pc")]
        public string ImageSrcPC { get; set; }

        /// <summary>
        /// 游戏图片_App
        /// </summary> 
 		[Column("image_src_app")]
        public string ImageSrcApp { get; set; }

        /// <summary>
        /// 游戏描述
        /// </summary> 
 		[Column("game_desc")]
        public string GameDecs { get; set; }

        /// <summary>
        /// 是否可用, 默认为1。 0：否；1：是
        /// </summary> 
 		[Column("is_usable")]
        public int IsUsable { get; set; } = 1;

        /// <summary>
        /// 排序序号
        /// </summary> 
        [Column("sort_no")]
        public int SortNo { get; set; } = 1;

        /// <summary>
        /// 创建时间
        /// </summary> 
 		[Column("create_time")]
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 是否推荐
        /// </summary>
        [Column("is_recommend")]
        public int IsRecommend { get; set; }

        /// <summary>
        /// 推荐中的推荐游戏
        /// </summary>
        [Column("tj_ls_recommend")]
        public int TjIsRecommend { get; set; }

        /// <summary>
        /// 游戏属性 1 老虎机 2捕鱼  3体育  4现场
        /// </summary>
        [Column("game_properties")]
        public int GameProperties { get; set; }

        /// <summary>
        /// 平台code值
        /// </summary>
        [Column("plat_code")]
        public int PlatCode { get; set; }

        /// <summary>
        /// 是否横竖屏 1横屏  0竖屏
        /// </summary>
        [Column("is_horizontal_screen")]
        public int IsHorizontalScreen { get; set; }

        /// <summary>
        /// 是否奖池老虎机
        /// </summary>
        [Column("is_jackpot")]
        public int IsJackpot { get; set; }

        /// <summary>
        /// 是否特殊奖励老虎机
        /// </summary>
        [Column("is_special")]
        public int IsSpecial { get; set; }

        /// <summary>
        /// 是否用浏览器打开 0 否 1是
        /// </summary>
        [Column("is_browser")]
        public int IsBrowser { get; set; }

        /// <summary>
        /// 是否单一钱包游戏
        /// </summary>
        [Column("is_sw_game")]
        public int IsSwGame { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [Column("update_time")]
        public DateTime UpdateTime { get; set; }

        /// <summary>
        /// 1 有试玩 0无试玩
        /// </summary>
        [Column("have_try_play")]
        public int HaveTryPlay { get; set; }

        /// <summary>
        /// 是否关闭转改
        /// </summary>
        [Column("is_close")]
        public int IsClose { get; set; }

        /// <summary>
        /// 是否删除
        /// </summary>
        [Column("is_delete")]
        public int IsDelete { get; set; }

        /// <summary>
        /// 仅仅PC
        /// </summary>
        [Column("is_onlypc")]
        public int IsOnlyPC { get; set; }

        /// <summary>
        /// 是否有效游戏 0无效  1有效
        /// </summary>
        [Column("is_effective_game")]
        public int IsEffectiveGame { get; set; }

        public string game_name { get; set; }

        public string agent_code { get; set; }
    }
}
