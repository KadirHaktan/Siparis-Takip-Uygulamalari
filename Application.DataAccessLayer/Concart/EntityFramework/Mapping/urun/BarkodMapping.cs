using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Application.Entity.Urun;

namespace Application.DataAccessLayer.Concart.EntityFramework.Mapping.urun
{
    public class BarkodMapping:EntityTypeConfiguration<Barkod>
    {
        public BarkodMapping()
        {
            ToTable(@"Barkod", @"dbo");

            HasKey(b => b.ID);

            Property(b => b.ID).HasColumnName("ID");
            Property(b => b.UrunID).HasColumnName("UrunID");
            Property(b => b.BarkodNo).HasColumnName("BarkodNo");
        }
    }
}
