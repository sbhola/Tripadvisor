using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.Linq;
using MongoDB.Driver.Builders;
using MongoDB.Driver.GridFS;
using MongoDB.Bson.Serialization;


namespace TripadvisorService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class TripadvisorService : ITripadvisorService
    {
        public Hotel GetHotelByName(string name)
        {
            var connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var server = client.GetServer();

            var database = server.GetDatabase("testdb"); // "test" is the name of the database

            // "entities" is the name of the collection
            var collection = database.GetCollection<Hotel>("hotels");

            var query = Query<Hotel>.EQ(h => h.Name, name);
            var hotel = collection.FindOne(query);

            var bsonObject = hotel.ToBsonDocument();

            var result = BsonSerializer.Deserialize<Hotel>(bsonObject);

            return result;
        }
    }
}
