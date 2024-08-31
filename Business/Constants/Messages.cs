using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants//sabit damek proje sabitleri metinler gibi
{
    public static class Messages//sürekli newlememek için static verdik
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün İsmi Geçersiz";
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string ProductsListed="Ürünler Listelendi";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 15 ürün olabilir";
        public static string ProductdontAdded = "Aynı isimde ürün bulunmaktadır";
        public static string ProductNameAlreadyExists="Aynı isimde Tekrar kullanılamaz";
        public static string CheckIfCategoryLimitExceded="Categori limitine ulaşıldı";
        public static string AuthorizationDenied="Yetkiniz Yok";
        internal static string UserRegistered="Kayıt Olundu";
        //internal static User UserNotFound="";
        //internal static User PasswordError=
        internal static string SuccessfulLogin="Başarılı Giriş";
        internal static string UserAlreadyExists="Kullanıcı Mevcut Değil";
        internal static string AccessTokenCreated="Token Oluşturuldu";
        internal static string CategoryLimitExceded="Category Limiti Geçildi";
    }
}
