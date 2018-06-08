using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Music.App_Start
{
    public class MongoContext
    {
        public MongoDatabase database;

        public MongoContext()
        {
            var port = 27017;
            var connectionStrnig = "mongodb://localhost:" + port;
            var dbName = "music_nosql";
            var client = new MongoClient(connectionStrnig);
            var server = client.GetServer();
            database = server.GetDatabase(dbName);
        }

    }
}