using Application.Entity.Musteri;
using Application.Entity.Urun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Application.UserInterface.Models.EntityModels.Listeleme
{
    public class MusteriUrunEntityModel
    {
        public List<Musteri> Musteriler { get; set; }
        public List<Adres> Adresler { get; set; }
        public List<Telefon> Telefonlar { get; set; }

        public List<Urun> Urunler { get; set; }
        public List<Barkod> Barkodlar { get; set; }
    }
}