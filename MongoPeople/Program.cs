using System;
using MongoDB.Driver;

namespace MongoPeople
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbName = "People";
            var connString = "mongodb+srv://jkloetzer:Juke0ut1m!@cluster0-vdmjk.mongodb.net/test?retryWrites=true&w=majority";

            var client = new MongoClient(connString + dbName);

            Console.WriteLine("Welcome to MongoPeople");

            Console.ReadKey();
        }
    }
}
