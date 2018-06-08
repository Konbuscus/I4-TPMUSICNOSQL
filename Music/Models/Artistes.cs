using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Music.Models
{
    public class Artistes
    {
        public ObjectId _id { get; set; }
        public string artistName { get; set; }
        public string artistType { get; set; }
        public string artistCover { get; set; }
        public string artistMusicType { get; set; }
        public string artistCountry { get; set; }

        public BsonArray albums { get; set; }

    }
}