using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Application.Entity.Musteri;

namespace Application.DataAccessLayer.Concart.EntityFramework.Mapping.musteri
{
   public class AdresMapping:EntityTypeConfiguration<Adres>
    {
        public AdresMapping()
        {
            ToTable(@"Adres", @"dbo");

            HasKey(a => a.ID);

            Property(a => a.ID).HasColumnName("ID");
            Property(a => a.MusteriID).HasColumnName("MusteriID");
            Property(a => a.TamAdres).HasColumnName("TamAdres");
        }
    }
}
