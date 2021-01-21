using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1= new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnistInStock = 6;

            Product product2 = new Product { Id = 2, CategoryId = 5,
                UnistInStock=6, ProductName="Kalem",UnitPrice=25  };
                 //Stack                    Heap
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);

            /* 
            productManager.Topla2(3,6);
            int toplamaSonuc = productManager.Topla(3, 6);
            Console.WriteLine(toplamaSonuc*2);
            */


        }
    }
}
