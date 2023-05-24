using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoShcool.DB
{
    public class MonD
    {
        private string connection = "mongodb://localhost:27017";
        private IMongoDatabase database;

        public MonD()
        {
            var client = new MongoClient(connection);
            database = client.GetDatabase("AutoSchool");
        }

        
    }
}
