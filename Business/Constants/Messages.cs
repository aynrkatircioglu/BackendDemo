using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        internal static string MaintenanceTime = "Sistem bakımda";
        internal static string ProductsListed = "Ürünler listelendi";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir";
        public static string ProductNameAlreadyExists = "Ürün ismi sistemde var";
        public static string CategoryLimitExceded = "maksimum kategori sayısında olduğunuzdan sisteme ürün eklenemiyor";
        public static string AuthorizationDenied = "bu işlemi yapmaya yetkiniz yok";
        public static string UserRegistered = "kullanıcı kaydedildi";
        public static string UserNotFound = "kullanıcı bulunamadı";
        public static string PasswordError = "şifre hatası";
        public static string SuccessfulLogin = "giriş başarılı";
        public static string UserAlreadyExists = "kullanıcı zaten var";
        public static string AccessTokenCreated = "token oluşturuldu";
      
    }
}
