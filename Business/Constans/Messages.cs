using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constans //Constant sabit demek projeye özel sabitleri buraya yazıyoruz 
{
    public static class Messages //static verdiğimizde newlemeye gerek kalmıyor
    {
        public static string ProductAdded = "Ürün Eklendi"; //Publicler PascalCase yazılır
        public static string ProductNameInvalid = "Ürün İsmi Geçersiz";
        public static string MaintenanceTime = "Sistem Bakıma Alındı";
        public static string ProductsListed = "Ürünler Listelendi";
        public static string ProductCountOfCategoryError = "Kategorideki ürün sayısını aştınız";
        public static string ProductNameAlreadyResults = "Aynı isimde bir ürün bulunmaktadır";
        public static string CategoryLimitExceded = "Kategori Limiti Aşıldı";
    }
}
