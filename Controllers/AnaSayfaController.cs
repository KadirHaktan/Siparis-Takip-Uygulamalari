using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Application.UserInterface.Controllers
{
    public class AnaSayfaController : Controller
    {
        // GET: AnaSayfa
        public ActionResult Siparis()
        {
            return View();
        }
    }
}