using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constans //Constant sabit demek projeye özel sabitleri buraya yazıyoruz 
{
    public static class Messages //static verdiğimizde newlemeye gerek kalmıyor
    {
        public static string ProductAdded = "Ürün Eklendi"; //Publicler PascalCase yazılır
        public static string ProductNameInvalid = "Ürün İsmi Geçersiz";
        internal static string MaintenanceTime = "Sistem Bakıma Alındı";
        internal static string ProductsListed = "Ürünler Listelendi";
    }
}
