using Core.Entities.Concrete;
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
        public static string AuthorizationDenied = "Yetkiniz Bulunmamaktadır.";
        public static string UserRegistered = "Kayıt İşlemi Başarılı";
        public static string UserNotFound = "Kullanıcı Bulunamadı";
        public static string PasswordError = "Parola Hatalı";
        public static string SuccessfulLogin = "Giriş Başarılı";
        public static string UserAlreadyExists = "Kullanıcı Zaten Var";
        public static string AccessTokenCreated= "Erişim Jetonu Oluşturuldu";
    }
}
