using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace Otel_Uygulaması.Controllers
{
    public class DefaultController : Controller
    {
        Models.Siniflar.Context c = new Models.Siniflar.Context();

        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();

        }
        public PartialViewResult Partial1()
        {
            var degerler = c.Blogs.Take(6).ToList();    
            return PartialView(degerler);
        }
        public PartialViewResult Partial3()
        {
            var degerler = c.Blogs.Take(6).ToList();
            return PartialView(degerler);
        }
        public PartialViewResult Partial4()
        {
            // Çekmek istediğiniz ID'leri içeren bir liste
            List<int> istenenIDListesi = new List<int> { 26, 21 };

            // Belirli ID'leri içeren blog verilerini çekmek için LINQ sorgusu
            var deger = c.Blogs
                .Where(blog => istenenIDListesi.Contains(blog.ID)) // Belirli ID'leri içerenleri filtrele

                .ToList();

            return PartialView(deger);

        }
        public PartialViewResult partial5()
        {
            // Çekmek istediğiniz ID'leri içeren bir liste
            List<int> istenenIDListesi = new List<int> { 22, 23, 24 };

            // Belirli ID'leri içeren blog verilerini çekmek için LINQ sorgusu
            var deger = c.Blogs
                .Where(blog => istenenIDListesi.Contains(blog.ID)) // Belirli ID'leri içerenleri filtrele
                
                .ToList();

            return PartialView(deger);

        }

        public ActionResult DetaylıBilgi()
        {
            List<int> istenenIDListesi = new List<int> { 33, 34, 35};

            // Belirli ID'leri içeren blog verilerini çekmek için LINQ sorgusu
            var deger = c.Blogs
                .Where(blog => istenenIDListesi.Contains(blog.ID)) // Belirli ID'leri içerenleri filtrele

                .ToList();

            return PartialView(deger);
        }
        public ActionResult Rezervasyon()
        {
            return View();
        }
    }

   
}