using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Concrete;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListed = "Ürünler listelendi";
        public static string ProductCountOfCategoryError = "Bir kategoriye en fazla 10 ürün ekleyebilirsiniz";
        public static string ProductUpdated = "Ürün güncellendi";
        public static string ProductNameAlreadyExists = "Bu isimde zaten başka bir ürün var";
        public static string CategoryLimitExceded = "Kategori sınırı aşıldığından ürün eklenemez.";
        public static string CategoryListed = "Kategoriler listelendi";
        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string UserRegistered { get; set; }
        public static User UserNotFound { get; set; }
        public static User PasswordError { get; set; }
        public static string SuccessfulLogin { get; set; }
        public static string UserAlreadyExists { get; set; }
        public static string AccessTokenCreated { get; set; }
    }
}
