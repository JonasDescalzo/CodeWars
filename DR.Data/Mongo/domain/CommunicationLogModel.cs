using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DR.Data.Mongo.domain
{
    [BsonIgnoreExtraElements]
    public class CommunicationLogModel
    {
        public string _id { get; set; }

        public int PostId { get; set; }

        public string Username { get; set; }

        public int ActionType { get; set; }//0 AddPost, 1 AddComment, 2 LikePost, 3 UnlikePost, 4 Update Post/Comment

        public string TypeCode { get; set; }//AddPost, AddComment, LikePost, UnlikePost, UpdatePostComment

        public DateTime CreateTime { get; set; }

        public int StatusCode { get; set; }

        public string Request { get; set; }


    }
}
