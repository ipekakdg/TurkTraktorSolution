using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurkTraktorProje.Entities;

namespace TurkTraktorProje.Context
{
    public class TurkTraktorContext:DbContext
    {
        public DbSet<Depolar> Depolars { get; set; }
        public DbSet<IadeHareketleri> IadeHareketleris { get; set; }
        public DbSet<Kategoriler> Kategorilers { get; set; }
        public DbSet<Musteriler> Musterilers { get; set; }
        public DbSet<Personeller> Personellers { get; set; }
        public DbSet<Saticilar> Saticilars { get; set; }
        public DbSet<Satislar> Satislars { get; set; }
        public DbSet<SiparisDetay> SiparisDetays { get; set; }
        public DbSet<Siparisler> Siparislers { get; set; }
        public DbSet<StokHareketleri> StokHareketleris { get; set; }
        public DbSet<Tedarikciler> Tedarikcilers { get; set; }
        public DbSet<Urunler> Urunlers { get; set; }
        public DbSet<Asamalar> Asamalars { get; set; }
        public DbSet<Boyamalar> Boyamalars { get;set; }
        public DbSet<Imalatlar> Imalatlars { get; set; }
        public DbSet<MalzemeTemini> MalzemeTeminis { get; set; }
        public DbSet<Montajlar> Montajlars { get;set; }
        public DbSet<Sevkiyatlar> Sevkiyatlars { get; set; }
        public DbSet<Tasarim> Tasarims { get; set; }
        public DbSet<Testler> Testlers { get; set; }
    }
}
