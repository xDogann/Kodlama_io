using System;


namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2; // Mobilya
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitInStock = 4;

            Product product2 = new Product { 
                Id = 2, CategoryId = 5, UnitInStock = 5,
                ProductName = "Kalem", UnitPrice = 30 };

            /*
            Case sensitive
            ProductManager türünde productManager adında değişken oluşturuyoruz
            Pascal Case    camelCase                                    */
            ProductManager productManager = new ProductManager();

            productManager.Add(product1);
            productManager.Update(product2);
            productManager.Delete(product2);

        }

        // Dont repeat yourself - DRY - Clean Code - Best Prectice
    }
}