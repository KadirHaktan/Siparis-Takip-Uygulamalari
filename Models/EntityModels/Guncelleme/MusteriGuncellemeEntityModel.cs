using Application.Entity.Musteri;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Application.UserInterface.Models.EntityModels.Guncelleme
{
    public class MusteriGuncellemeEntityModel
    {
        public List<Musteri> Musteri_Liste { get; set; }
        public Musteri Musteri { get; set; }
        public Telefon Telefon { get; set; }
        public Adres Adres { get; set; }
    }
}