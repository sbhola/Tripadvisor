using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Nest;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.Linq;
using MongoDB.Driver.Builders;
using MongoDB.Driver.GridFS;


namespace ElasticSearchFixtures
{
    [TestClass]
    public class ElasticSearchFixture
    {
        [TestMethod]
        public void TestCreateIndexOnDocumentsInMongoDb()
        {
            var MongoconnectionString = "mongodb://localhost";
            var Mongoclient = new MongoClient(MongoconnectionString);
            var Mongoserver = Mongoclient.GetServer();
            List<Hotel> hotellist = new List<Hotel>();

            var Mongodatabase = Mongoserver.GetDatabase("testdb"); // "test" is the name of the database

            // "entities" is the name of the collection
            var collection = Mongodatabase.GetCollection<Hotel>("hotels");


            //////elastic settings
            Uri localhost = new Uri("http://localhost:9200");
            var Elasticsetting = new ConnectionSettings(localhost,defaultIndex:"hotels-app");
            var Elasticclient = new ElasticClient(Elasticsetting);

            foreach(var Mongodocument in collection.FindAll())
            {
                //hotellist.Add(Mongodocument);
                var index = Elasticclient.Index(Mongodocument);
               // Elasticclient.Index(Mongodocument, "hotels", "hotel", Mongodocument.Id);

            }


            //Assert.AreEqual(3, hotellist.Count);

        }

        [TestMethod]
        public void TestGetQueryResultFromElastic()
        {
            Uri localhost = new Uri("http://localhost:9200");
            var Elasticsetting = new ConnectionSettings(localhost, defaultIndex: "hotels-app");
            var Elasticclient = new ElasticClient(Elasticsetting);


        }
    }
}
