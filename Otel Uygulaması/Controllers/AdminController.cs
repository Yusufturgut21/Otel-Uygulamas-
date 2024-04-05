﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Otel_Uygulaması.Models;
using Otel_Uygulaması.Models.Siniflar;

namespace Otel_Uygulaması.Controllers
{
    public class AdminController : Controller
    {
        Context c = new Context();
        // GET: Admin
        public ActionResult Index()
        {
            var degerler = c.Blogs.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniBlog()
        { 
            return View();
        }
        [HttpPost]
        public ActionResult YeniBlog(Blog p)
        {
           c.Blogs.Add(p);
           c.SaveChanges();
           return RedirectToAction("Index");
        }
        public ActionResult BlogSil(int id)
        {
            var b = c.Blogs.Find(id);
            c.Blogs.Remove(b);
            c.SaveChanges();
            return RedirectToAction("Index");

        }
      
        public ActionResult BlogGetir(int id)
        {
        
                var bl = c.Blogs.Find(id);
                return View("BlogGetir", bl);
               
         }
        public ActionResult BlogGuncelle(Blog b)
        {
            var blg = c.Blogs.Find(b.ID);
            blg.Aciklama = b.Aciklama;
            blg.Baslik = b.Baslik;
            blg.BlogImage = b.BlogImage;
            blg.Tarih = b.Tarih;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
           
        
    }
}
