using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Product  // Ürün
    {
        public int Id { get; set; } // Ürün Numarası
        public int CategoryId { get; set; } // Referans Alanları
        public string ProductName { get; set; } // Ürün İsmi
        public double UnitPrice { get; set; } // Ürün Fiyatı
        public int UnitInStock { get; set; } // Ürün Stok Adedi

        // CRUD Operation - Create Read Update Delete 
    }
}
