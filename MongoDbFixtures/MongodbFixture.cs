using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using MongoDB.Driver.Linq;
using MongoDB.Driver.Builders;
using MongoDB.Driver.GridFS;

namespace MongoDbFixtures
{
    [TestClass]
    public class MongodbFixture
    {
        //[TestMethod]
        //public void TestCreateLocationCollectionInMongoDb()
        //{
        //    var connectionString = "mongodb://localhost";
        //    var client = new MongoClient(connectionString);
        //    var server = client.GetServer();

        //    var database = server.GetDatabase("testdb"); // "test" is the name of the database

        //    // "entities" is the name of the collection
        //    var collection = database.GetCollection<Location>("locations");

        //    var loc1 = new Location
        //    {
        //        Address = "Kalyaninagar",
        //        City = "Pune",
        //        Country = "India",
        //        Latitude = 18.34,
        //        Longitude = 22.920
        //    };

        //    var loc2 = new Location
        //    {
        //        Address = "Vimannagar",
        //        City = "Pune",
        //        Country = "India",
        //        Latitude = 18.74,
        //        Longitude = 22.25
        //    };

        //    var loc3 = new Location
        //    {
        //        Address = "Camp",
        //        City = "Pune",
        //        Country = "India",
        //        Latitude = 18.21,
        //        Longitude = 22.10
        //    };

        //    var loc4 = new Location
        //    {
        //        Address = "Shivajinagar",
        //        City = "Pune",
        //        Country = "India",
        //        Latitude = 18.33,
        //        Longitude = 22.28
        //    };

        //    var loc5 = new Location
        //    {
        //        Address = "Baner",
        //        City = "Pune",
        //        Country = "India",
        //        Latitude = 18.24,
        //        Longitude = 22.10
        //    };

        //    collection.Insert(loc1);
        //    collection.Insert(loc2);
        //    collection.Insert(loc3);
        //    collection.Insert(loc4);
        //    collection.Insert(loc5);

        //    var colCount = collection.Count();
        //    Assert.AreEqual(5, colCount);

        //}

        //[TestMethod]
        //public void TestCreateHotelCollectionInMongoDb()
        //{

        //    var connectionString = "mongodb://localhost";
        //    var client = new MongoClient(connectionString);
        //    var server = client.GetServer();

        //    var database = server.GetDatabase("testdb"); // "test" is the name of the database

        //    // "entities" is the name of the collection
        //    var collection = database.GetCollection<Hotel>("hotels");

        //    var loc1 = new Location
        //    {
        //        Address = "Kalyaninagar",
        //        City = "Pune",
        //        Country = "India",
        //        Latitude = 18.34,
        //        Longitude = 22.920
        //    };

        //    var rev1 = new Review
        //    {
        //        Title = "Good Hotel",
        //        Description = "xejd e ebkbke",
        //        Rating = 3,
        //        AddedByUserName = "sid",
        //        UTCAddedOn = DateTime.UtcNow
        //    };

        //    var rev2 = new Review
        //    {
        //        Title = "Nice Hotel",
        //        Description = "x nkej ne bxejd e ebkbke",
        //        Rating = 4,
        //        AddedByUserName = "yoyo",
        //        UTCAddedOn = DateTime.UtcNow
        //    };

        //    var revs1 = new List<Review>();
        //    revs1.Add(rev1);
        //    revs1.Add(rev2);

        //    var hotel1 = new Hotel
        //    {
        //        Name = "Hyatt",
        //        location = loc1,
        //        Rating = 4,
        //        Reviews = revs1
        //    };

        //    var loc3 = new Location
        //    {
        //        Address = "Vimannagar",
        //        City = "Pune",
        //        Country = "India",
        //        Latitude = 18.24,
        //        Longitude = 22.28
        //    };

        //    var rev3 = new Review
        //    {
        //        Title = "Good Hotel",
        //        Description = "xejd e ebkbke",
        //        Rating = 3,
        //        AddedByUserName = "sid",
        //        UTCAddedOn = DateTime.UtcNow
        //    };

        //    var rev4 = new Review
        //    {
        //        Title = "Nice Hotel",
        //        Description = "x nkej ne bxejd e ebkbke",
        //        Rating = 4,
        //        AddedByUserName = "yoyo",
        //        UTCAddedOn = DateTime.UtcNow
        //    };

        //    var revs2 = new List<Review>();
        //    revs2.Add(rev3);
        //    revs2.Add(rev4);

        //    var hotel2 = new Hotel
        //    {
        //        Name = "Marriot",
        //        location = loc1,
        //        Rating = 5,
        //        Reviews = revs1
        //    };


        //    var loc5 = new Location
        //    {
        //        Address = "Dilsukhnagar",
        //        City = "Hyderabad",
        //        Country = "India",
        //        Latitude = 13.34,
        //        Longitude = 21.920
        //    };

        //    var rev5 = new Review
        //    {
        //        Title = "Good Hotel",
        //        Description = "xejd e ebkbke",
        //        Rating = 3,
        //        AddedByUserName = "sid",
        //        UTCAddedOn = DateTime.UtcNow
        //    };

        //    var rev6 = new Review
        //    {
        //        Title = "Nice Hotel",
        //        Description = "x nkej ne bxejd e ebkbke",
        //        Rating = 4,
        //        AddedByUserName = "yoyo",
        //        UTCAddedOn = DateTime.UtcNow
        //    };

        //    var revs3 = new List<Review>();
        //    revs3.Add(rev5);
        //    revs3.Add(rev6);

        //    var hotel3 = new Hotel
        //    {
        //        Name = "Lemon Tree",
        //        location = loc1,
        //        Rating = 4,
        //        Reviews = revs1
        //    };


        //    collection.Insert(hotel1);
        //    collection.Insert(hotel2);
        //    collection.Insert(hotel3);

        //    var hotelCount = collection.Count();

        //    Assert.AreEqual(3, hotelCount);

        //}

        [TestMethod]
        public void TestGetHotelByName()
        {
            var connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var server = client.GetServer();

            var database = server.GetDatabase("testdb"); // "test" is the name of the database

            // "entities" is the name of the collection
            var collection = database.GetCollection<Hotel>("hotels");

            var query = Query<Hotel>.EQ(h => h.Name, "Hyatt");
            var hotel = collection.FindOne(query);

            Assert.AreEqual("Pune", hotel.location.City);
        }

    }

}
