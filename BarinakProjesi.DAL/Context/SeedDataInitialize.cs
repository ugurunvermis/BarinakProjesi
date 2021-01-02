using BarinakProjesi.DATA.Context;
using Microsoft.EntityFrameworkCore;

namespace BarinakProjesi.DAL.Context
{
    public static class SeedDataInitialize
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KullaniciRolu>().HasData(
                new KullaniciRolu { id = 1, rol = "Admin", },
                new KullaniciRolu { id = 2, rol = "User" });

            modelBuilder.Entity<Kullanicilar>().HasData(
                new Kullanicilar { id = 1, kullanici_rol_id = 1, eposta = "u101210016@sakarya.edu.tr", sifre = "123", ad = "Uğur", soyad = "Ünvermiş", telefon = "050443772382", il = "Ankara", ilce = "Etimesgut", mahalle = "Elvan Mahallesi", adres = "1952. Sokak No:3/5" },
                new Kullanicilar { id = 2, kullanici_rol_id = 2, eposta = "ugurunvermis@gmail.com", sifre = "123", ad = "User Uğur", soyad = "Ünvermiş", telefon = "050443772382", il = "Ankara", ilce = "Etimesgut", mahalle = "Elvan Mahallesi", adres = "1952. Sokak No:3/5" }
                );
        }
    }
}
