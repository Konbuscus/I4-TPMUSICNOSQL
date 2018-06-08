using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;
namespace Music.Models
{
    public class Albums
    {
        public ObjectId _id { get; set; }
        public string albumName { get; set; }
        public int albumYear { get; set; }
        public string albumPrice { get; set; }
        public string albumPicture { get; set; }
        public string albumType { get; set; }
        public Artistes artist { get; set; }
    }
}