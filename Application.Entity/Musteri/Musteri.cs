using Application.Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Entity.Musteri
{
   public class Musteri:IEntity
    {
        
        public int ID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
    }
}
