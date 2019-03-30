using Application.Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Entity.Musteri
{
    public class Adres:IEntity
    {
        public int ID { get; set; }
        
        public virtual int MusteriID { get; set; }

        public string TamAdres { get; set; }
    }
}
