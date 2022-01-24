using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeWars.Models.CommunicationModels
{
    public class PostCommentTestRequest
    {

        public string username { get; set; }
        public string type { get; set; }
        public string state { get; set; }
        public List<DateTime> time { get; set; }
        public string countryCode { get; set; }
        public string postId { get; set; }
        public int pageIndex { get; set; }
        public int pageSize { get; set; }
    }
}
