using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Application.Entity.Musteri;
using System.Data.Entity;

namespace Application.DataAccessLayer.Concart.EntityFramework.Mapping.musteri
{
   public class MusteriMapping:EntityTypeConfiguration<Musteri>
    {
       public MusteriMapping()
        {
            ToTable(@"Musteri", @"dbo");

            HasKey(m => m.ID);

            Property(m => m.ID).HasColumnName("ID");
            Property(m => m.Ad).HasColumnName("Ad");
            Property(m => m.Soyad).HasColumnName("Soyad");
            
        }

        
    }
}
