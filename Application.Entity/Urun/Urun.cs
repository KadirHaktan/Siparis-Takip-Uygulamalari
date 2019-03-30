using Application.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Entity.Urun
{
   public class Urun:IEntity
    {
        public int ID { get; set; }
        public string Ad { get; set; }
        public decimal Fiyat { get; set; }
        public int Adet { get; set; }
        public int MusteriID { get; set; }
        public int BarkodID { get; set; }
    }
}
