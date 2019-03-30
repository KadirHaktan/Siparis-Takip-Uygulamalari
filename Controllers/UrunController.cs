using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Application.UserInterface.Controllers
{
    public class UrunController : Controller
    {
        // GET: Urun
        public ActionResult Ekleme()
        {
            return View();
        }

        [HttpGet]
        public ActionResult UrunEkleme()
        {
            return View();
        }

        public ActionResult Silme()
        {
            return View();
        }

        public ActionResult Güncelleme()
        {
            return View();
        }
    }
}