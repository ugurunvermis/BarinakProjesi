﻿using BarinakProjesi.DATA.Context;
using Microsoft.EntityFrameworkCore;

namespace BarinakProjesi.DAL.Context
{
    public class BarinakDbContext : DbContext
    {
        public BarinakDbContext(DbContextOptions<BarinakDbContext> options)
            : base(options)
        { }

        public DbSet<Asi> AsiTakvimi { get; set; }
        public DbSet<BarinakBilgileri> BarinakBilgileri { get; set; }
        public DbSet<BeslenmeProgrami> BeslenmeProgrami { get; set; }
        public DbSet<CalismaSaatleri> CalismaSaatleri { get; set; }
        public DbSet<Cinsiyet> Cinsiyet { get; set; }
        public DbSet<HayvanCinsleri> HayvanCinsleri { get; set; }
        public DbSet<HayvanFotograflari> HayvanFotograflari { get; set; }
        public DbSet<HayvanTurleri> HayvanTurleri { get; set; }
        public DbSet<KayitliHayvanlar> KayitliHayvanlar { get; set; }
        public DbSet<Kullanicilar> Kullanicilar { get; set; }
        public DbSet<KullaniciRolu> KullaniciRolu { get; set; }
        public DbSet<SahiplenmeBasvuruDurumlari> SahiplenmeBasvuruDurumlari { get; set; }
        public DbSet<SahiplenmeTalepleri> SahiplenmeTalepleri { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*
            * SeedDataInitialize.cs içindeki Seed metodu ile database oluşturulurken
            * örnek verileri database'e basıyor.
             */
            modelBuilder.Seed();
        }
    }
}
