using Application.Entity.Musteri;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Application.UserInterface.Models.EntityModels.Ekleme
{
    public class MüşteriEklemeEntityModel
    {
        public Adres _adres { get; set; }
        public Musteri _musteri { get; set; }
        public Telefon _telefon { get; set; }


        public MüşteriEklemeEntityModel()
        {
            _adres = new Adres();
            _musteri = new Musteri();
            _telefon = new Telefon();
        }

    }
}