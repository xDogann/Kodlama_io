using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class ProductManager // ProductService - Ürün ile ilgili operasyonlar
    {
        public void Add(Product product)
        {
            Console.WriteLine("- " + product.ProductName + " eklendi.");
        }
        public void Update(Product product)
        {
            Console.WriteLine("- " + product.ProductName + " güncellendi.");
        }

        public void Delete(Product product)
        {
            Console.WriteLine("- " + product.ProductName + " silindi.");
        }
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi1;
        }

        public void Topla2(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1 + sayi1); 
        }
    }
}
