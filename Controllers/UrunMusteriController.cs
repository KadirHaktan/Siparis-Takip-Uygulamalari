using Application.BusinessLogicLayer.Abstract;
using Application.BusinessLogicLayer.Depency_Injection_Tools.ninject;
using Application.Entity.Musteri;
using Application.Entity.Urun;
using Application.UserInterface.Models.EntityModels.Listeleme;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Application.UserInterface.Controllers
{
    public class UrunMusteriController : Controller
    {

        IServices<Musteri> musteri_logic = InstancesFactory.CreateInstance<IServices<Musteri>>();
        IServices<Telefon> telefon_logic = InstancesFactory.CreateInstance<IServices<Telefon>>();
        IServices<Adres> adres_logic = InstancesFactory.CreateInstance<IServices<Adres>>();

        IServices<Urun> urun_logic = InstancesFactory.CreateInstance<IServices<Urun>>();
        IServices<Barkod> barkod_logic = InstancesFactory.CreateInstance<IServices<Barkod>>();






        // GET: UrunMusteri
        public ActionResult TumUrunMusteriler()
        {
            var model = new MusteriUrunEntityModel
            {
                Musteriler = musteri_logic.GetAll(),
                Adresler = adres_logic.GetAll(),
                Telefonlar=telefon_logic.GetAll(),
                Urunler=urun_logic.GetAll(),
                Barkodlar=barkod_logic.GetAll()
                

            };

            return View(model);
        }
    }
}