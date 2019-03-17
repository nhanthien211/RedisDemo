using System;

namespace ProductEntity
{
    public class Product
    {
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int Quantity { get; set; }

        public void PrintProductDetail()
        {
            Console.WriteLine("Product Name: " + ProductName);
            Console.WriteLine("Product Description: " + ProductDescription);
            Console.WriteLine("Quantity: " + Quantity);
        }
    }
}
