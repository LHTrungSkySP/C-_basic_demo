using System;

namespace Virtual
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product();
            Product p2 = new Iphone();
            p1.TestProduct();   // In ra: Giá sản phẩm 0
            p2.TestProduct();
        }
    }
    class Product
    {
        protected double price = 0;

        // Phương thức ảo ProductInfo
        public virtual void ProductInfo()
        {
            Console.WriteLine($"Price: {price}");
        }

        public void TestProduct()
        {
            this.ProductInfo();
        }
    }
    class Iphone : Product
    {
        public Iphone()
        {
            price = 500;
        }
        public override void ProductInfo()
        {
            Console.WriteLine($"Type: Iphone");
            base.ProductInfo();
        }
    }
}
