using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DR.Data.Mysql.Activity.Domain
{
    [Table("post_comment")]
    public class PostComment
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("parent_id")]
        public int ParentId { get; set; }

        [Column("username")]
        public string Username { get; set; }

        [Column("is_officer")]
        public int IsOfficer { get; set; }

        [Column("type")]
        public int ItemType { get; set; }

        [Column("state")]
        public int State { get; set; }

        [Column("photos")]
        public string Photos { get; set; }

        [Column("caption")]
        public string Caption { get; set; }

        [Column("likes")]
        public int Likes { get; set; }

        [Column("comment")]
        public string Comment { get; set; }

        [Column("create_time")]
        public DateTime DateCreated { get; set; }

        [Column("update_time")]
        public DateTime DateUpdated { get; set; }

        [Column("cid")]
        public string Cid { get; set; }

        [Column("cid_int")]
        public int CidInt { get; set; }

        [Column("is_hot")]
        public int IsHot { get; set; }

        [Column("country_code")]
        public string CountryCode { get; set; }
    }
}
