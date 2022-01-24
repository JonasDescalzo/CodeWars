using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DR.Data.Mongo.domain
{
    [BsonIgnoreExtraElements]
    public class LoginAndRegisterModel
    {
        public string _id { get; set; }

        public string username { get; set; }

        public string address { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        public string Province { get; set; }

        public string ip { get; set; }

        public string mac { get; set; }

        public string useragent { get; set; }

        public string device { get; set; }

        public string networkprovider { get; set; }

        public DateTime createtime { get; set; }

        public string httpUserAgent { get; set; }

        public string typecode { get; set; }

        public long unixTime { get; set; }
    }
}
