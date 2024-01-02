using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.Mvc;
using Otel_Uygulaması.Models.Siniflar;

namespace Otel_Uygulaması.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        Models.Siniflar.Context c = new Models.Siniflar.Context();
        public ActionResult Index()
        {
            var degerler = c.Hakkimizdas.ToList();  

            return View(degerler);
        }
    }
}