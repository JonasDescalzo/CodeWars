using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DR.Data.Mysql.UserAuth.Domain
{
    [Table("users_information")]
    public class UsersInformation
    {
        /// <summary>
        ///
        /// <summary>
        public string id { get; set; }
        /// <summary>
        ///username
        /// <summary>
        public string username { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string input_first_name { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string input_last_name { get; set; }
        /// <summary>
        ///
        /// <summary>
        public DateTime input_birth_day { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string input_sex { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string input_fullname { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string input_email { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string upload_card_image { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string ocr_fullname { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string ocr_first_name { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string ocr_last_name { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string ocr_id { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string ocr_birth_day { get; set; }
        /// <summary>
        ///0 OK 1 审核 2 faild
        /// <summary>
        public int pancard_ok { get; set; }
        /// <summary>
        ///
        /// <summary>
        public int isneed_pancard { get; set; }
        /// <summary>
        ///
        /// <summary>
        public DateTime create_time { get; set; }
        /// <summary>
        ///
        /// <summary>
        public DateTime update_time { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string country_code { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string cid { get; set; }
        /// <summary>
        ///Reason for audit failure
        /// <summary>
        public string ocr_faild_msg { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string msg { get; set; }
        /// <summary>
        ///
        /// <summary>
        public DateTime ocr_con_birth_day { get; set; }
        /// <summary>
        ///
        /// <summary>
        public string ocr_full_text { get; set; }

    }
}
