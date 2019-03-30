using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Application.Entity.Musteri;

namespace Application.DataAccessLayer.Concart.EntityFramework.Mapping.musteri
{
   public class TelefonMapping:EntityTypeConfiguration<Telefon>
    {
        public TelefonMapping()
        {
            ToTable(@"Telefon", @"dbo");

            HasKey(t => t.ID);

            Property(t => t.ID).HasColumnName("ID");
            Property(t => t.MusteriID).HasColumnName("MusteriID");
            Property(t => t.TelefonNo).HasColumnName("TelefonNo");
        }
    }
}
