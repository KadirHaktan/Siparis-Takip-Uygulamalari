using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Application.Entity.Urun;

namespace Application.DataAccessLayer.Concart.EntityFramework.Mapping.urun
{
   public class UrunMapping:EntityTypeConfiguration<Urun>
    {
        public UrunMapping()
        {

            ToTable(@"Urun", @"dbo");
       
            HasKey(u => u.ID);

            Property(u => u.ID).HasColumnName("ID");
            Property(u => u.Ad).HasColumnName("Ad");
            Property(u => u.Fiyat).HasColumnName("Fiyat");
            Property(u => u.Adet).HasColumnName("Adet");
            Property(u => u.MusteriID).HasColumnName("MusteriID");
            Property(u => u.BarkodID).HasColumnName("BarkodID");


        }
    }
}
