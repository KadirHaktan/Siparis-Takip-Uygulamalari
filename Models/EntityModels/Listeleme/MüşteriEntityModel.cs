using Application.Entity.Musteri;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Application.UserInterface.Models.EntityModels.Listeleme
{
    public class MüşteriEntityModel
    {
        public List<Musteri> Musteriler { get; set; }
        public List<Adres> Adresler { get; set; }
        public List<Telefon> Telefonlar { get; set; }
    }
}