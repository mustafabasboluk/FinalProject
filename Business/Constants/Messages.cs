using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintanceTime = "Sistem Bakımda";
        public static string ProductsListed = "Ürünler Listelendi";
        public static string ProductCountOfCategoryError = "";
        public static string ProductNameAlreadyExists = "Bu isimde zaten başka ürün var";
        internal static string CheckIfCategoryLimitExceded="Kategori limiti aşıldığı için yeni ürün eklenemiyor";
    }
}
