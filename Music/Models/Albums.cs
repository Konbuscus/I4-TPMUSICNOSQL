using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Music.Models
{
    public class Albums
    {
        public ObjectId _id { get; set; }
        public string albumName { get; set; }
        public int albumYear { get; set; }

        [BsonRepresentation(BsonType.Int32, AllowTruncation = true)]
        public float albumPrice { get; set; }
        public string albumPicture { get; set; }
        public string albumType { get; set; }
        public Artistes artist { get; set; }
    }
}