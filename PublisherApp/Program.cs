using Jil;
using ProductEntity;
using StackExchange.Redis;
using System;

namespace PublisherApp
{
    class Program
    {
        private const string Connection = "localhost";
        private const string Channel = "Product_Channel";
        private static ConnectionMultiplexer Redis = ConnectionMultiplexer.Connect(Connection);


        static void Main(string[] args)
        {
            var pubsub = Redis.GetSubscriber();
            while (true)
            {
                var productJson = CreateProductJson();
                pubsub.Publish(Channel, productJson);
                Console.WriteLine("New product added");
                Console.WriteLine("==========================");
            }
        }

        private static string CreateProductJson()
        {
            int quantity = 0;
            bool flag = false;
            Console.Write("Product Name: ");
            var name = Console.ReadLine();
            Console.Write("Product Description: ");
            var description = Console.ReadLine();
            while (!flag)
            {
                Console.Write("Quantity: ");
                try
                {
                    quantity = Convert.ToInt32(Console.ReadLine());
                    if (quantity > 0)
                    {
                        flag = true;
                    }
                    else
                    {
                        Console.WriteLine("Quantity must be positive integer");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Quantity must be positive integer");
                }
            }
            return JSON.Serialize(new Product
            {
                Quantity = quantity,
                ProductName = name,
                ProductDescription = description
            });
        }
    }
}
