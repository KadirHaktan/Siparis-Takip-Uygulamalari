using Application.DataAccessLayer.Concart.EntityFramework.Mapping.musteri;
using Application.DataAccessLayer.Concart.EntityFramework.Mapping.urun;
using Application.Entity.Musteri;
using Application.Entity.Urun;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DataAccessLayer.Concart.EntityFramework
{
   public class SiparisContext:DbContext
    {
        public SiparisContext()
        {
            Database.SetInitializer<SiparisContext>(null);
        }

        public DbSet<Musteri> Musteri { get; set; }
        public DbSet<Adres> Adres { get; set; }
        public DbSet<Telefon> Telefon { get; set; }

        public DbSet<Urun> Urun { get; set; }
        public DbSet<Barkod> Barkod { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new MusteriMapping());
            modelBuilder.Configurations.Add(new AdresMapping());
            modelBuilder.Configurations.Add(new TelefonMapping());

            modelBuilder.Configurations.Add(new UrunMapping());
            modelBuilder.Configurations.Add(new BarkodMapping());
        
        }
    }
}
