using Jil;
using ProductEntity;
using StackExchange.Redis;
using System;

namespace SubcriberApp
{
    class Program
    {
        private const string Connection = "localhost";
        private const string Channel = "Product_Channel";
        private static ConnectionMultiplexer Redis = ConnectionMultiplexer.Connect(Connection);

        static void Main(string[] args)
        {
            var pubsub = Redis.GetSubscriber();
            pubsub.Subscribe(Channel, (channel, json) => ProductAction(json));
            while (true) {}
        }

        private static void ProductAction(string json)
        {
            Console.WriteLine("New product information: ");
            var product = JSON.Deserialize<Product>(json);
            product.PrintProductDetail();
            Console.WriteLine("===========================");
        }
    }
}
