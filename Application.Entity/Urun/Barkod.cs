using Application.Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Entity.Urun
{
   public class Barkod:IEntity
    {
        public int ID { get; set; }

        public int UrunID { get; set; }

        public int BarkodNo { get; set; }
    }
}
