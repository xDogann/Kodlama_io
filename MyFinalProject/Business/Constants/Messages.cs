using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün İsmi Geçersiz";
        public static string MaintenanceTime = "Sistem Şuanda Bakımında.";
        public static string ProductListed = "Ürünler Listelendi.";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün eklenebilir.";

        public static string ProductNameAlreadyExists = "Böyle bir ürün sistemde kayıtlı";

        public static string CategoryLimitExceded = "Kategori Limiti Aşıldığı için yeni ürün eklenemiyor.";
    }
}
