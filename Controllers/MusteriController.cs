using Application.BusinessLogicLayer.Abstract;
using Application.BusinessLogicLayer.Concart.Concart.musteri;
using Application.BusinessLogicLayer.Depency_Injection_Tools.ninject;
using Application.DataAccessLayer.Concart.EntityFramework.MUSTERİ;
using Application.Entity.Musteri;
using Application.UserInterface.Models.EntityModels.Ekleme;
using Application.UserInterface.Models.EntityModels.Guncelleme;
using Application.UserInterface.Models.EntityModels.Listeleme;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Application.UserInterface.Controllers
{
    public class MusteriController : Controller
    {
        IServices<Musteri> musteri_logic = InstancesFactory.CreateInstance<IServices<Musteri>>();
        IServices<Telefon> telefon_logic = InstancesFactory.CreateInstance<IServices<Telefon>>();
        IServices<Adres> adres_logic = InstancesFactory.CreateInstance<IServices<Adres>>();

       
        // GET: Musteri

        public ActionResult MusteriAnaSayfa()
        {
            var model = new MüşteriEntityModel
            {
                Musteriler = musteri_logic.GetAll(),
                Adresler=adres_logic.GetAll(),
                Telefonlar=telefon_logic.GetAll()

                
            };

            return View(model);
        }
        
        public ActionResult Silme(Musteri musteri)
        {
            musteri_logic.Delete(musteri);
            return RedirectToAction("MusteriAnaSayfa");
        }

        
        [HttpGet]
        public ActionResult Ekleme(Musteri musteri)
        {
            musteri_logic.Add(musteri);
          

            return RedirectToAction("MusteriAnaSayfa");
            
        }

        public ActionResult Adding()
        {
            var model = new MüşteriEklemeEntityModel
            {
                _musteri = new Musteri()
            };

            return View(model);
        }

        public ActionResult Updating(Musteri musteri)
        {
            var model = new MusteriGuncellemeEntityModel
            {
                Musteri = musteri
            };

            return View(model);
        }

        [HttpPost]
        public ActionResult Güncelleme(Musteri musteri)
        {
            musteri_logic.Update(musteri);


            return RedirectToAction("MusteriAnaSayfa");
        }




    }
}