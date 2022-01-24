using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeWars.Models.CommunicationModels
{
    public class PostCommentTestResponse
    {
        public string Username { get; set; }

        public int TotalPost { get; set; }

        public int TodayPost { get; set; }

        public string Country { get; set; }

        public DateTime FirstPostDate { get; set; }

        public DateTime LastPostDate { get; set; }
    }
}
