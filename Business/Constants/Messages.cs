using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araç eklendi.";
        public static string CarDescriptionInvalid = "Araç açıklaması geçersiz.";
        public static string RentalInvalid = "Araç başka kullanıcıda.";
        public static string BrandAdded = "Marka eklendi.";
        public static string BrandDeleted = "Marka silindi.";
        public static string BrandUpdated = "Marka güncellendi.";
        public static string BrandsListed = "Markalar listelendi.";
        public static string CarsListed = "Araçlar listelendi.";
        public static string ColorAdded = "Renk eklendi.";
        public static string ColorDeleted = "Renk silindi.";
        public static string ColorUpdated = "Renk güncellendi.";
        public static string CustomerAdded = "Müşteri eklendi.";
        public static string CustomerDeleted = "Müşteri silindi.";
        public static string CustomerUpdated = "Müşteri güncellendi.";
        public static string RentalAdded = "Kiralama eklendi.";
        public static string RentalDeleted = "Kiralama silindi.";
        public static string RentalUpdated = "Kiralama güncellendi.";
        public static string UserAdded = "Kullanıcı eklendi.";
        public static string UserDeleted = "Kullanıcı silindi.";
        public static string UserUpdated = "Kullanıcı güncellendi.";
        public static string CarCountError = "Bir araç markasına en fazla 10 araç eklenebilir.";
        public static string CarDescriptionInvalidAlreadyExists = "İki aracın açıklaması aynı olamaz.";
        public static string BrandLimitExceeded = "Marka limiti aşıldı.";
        public static string CarImageDeleted = "Araç fotoğrafı silindi.";
        public static string CarImageAdded = "Araç fotoğrafı eklendi.";
        public static string AuthorizationDenied = "Yetkiniz yok!";
        public static string UserRegistered = "Kullanıcı oluşturuldu.";
        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string PasswordError = "Parola hatalı!";
        public static string SuccessfulLogin = "Giriş başarılı.";
        public static string UserAlreadyExists = "Bu kullanıcı sistemde zaten mevcuttur.";
        public static string AccessTokenCreated = "Access token oluşturuldu.";
    }
}
