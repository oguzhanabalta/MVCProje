using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataAccesLayer.Concrete;

namespace MVCProje.Controllers
{
    public class IstatistikController : Controller
    {
        Context db = new Context();
        
        public ActionResult Index()
        {
            var yazarsayisi = db.Writers.Count().ToString();
            ViewBag.y1 = yazarsayisi;

            var basliksayisi = db.Contents.Count().ToString();
            ViewBag.b1 = basliksayisi;

            var kategorisayisi = db.Categories.Count().ToString();
            ViewBag.k1 = kategorisayisi;

            var kategoribaslikfazla = db.Headings.GroupBy(x => x.Category.CategoryName).OrderByDescending(z => z.Count()).Select(y => y.Key).FirstOrDefault();
            ViewBag.kbf1 = kategoribaslikfazla;

            DateTime bugun = DateTime.Today;
            var bugunbaslik = db.Headings.Count(x => x.HeadingDate == bugun).ToString();
            ViewBag.b1 = bugunbaslik;


            var yazilimveri = db.Headings.Count(x => x.Category.CategoryName == "Yazılım").ToString();
            ViewBag.yaz1 = yazilimveri;

            var egitimveri = db.Headings.Count(x => x.Category.CategoryName == "Eğitim").ToString();
            ViewBag.yaz2 = egitimveri;

            var tiyatroveri = db.Headings.Count(x => x.Category.CategoryName == "Tiyatro").ToString();
            ViewBag.yaz3 = tiyatroveri;

            var kitapveri = db.Headings.Count(x => x.Category.CategoryName == "Kitap").ToString();
            ViewBag.yaz4 = kitapveri;

            var sporveri = db.Headings.Count(x => x.Category.CategoryName == "Spor").ToString();
            ViewBag.yaz5 = sporveri;

            var filmveri = db.Headings.Count(x => x.Category.CategoryName == "Film").ToString();
            ViewBag.yaz6 = filmveri;

            var teknolojiveri = db.Headings.Count(x => x.Category.CategoryName == "Teknoloji").ToString();
            ViewBag.yaz7 = teknolojiveri;

            var encokyorum = db.Contents.GroupBy(x => x.Heading.HeadingName).OrderByDescending(z => z.Count()).Select(y => y.Key).FirstOrDefault();
            ViewBag.yorum1 = encokyorum;

            var aharfi = (from x in db.Writers where x.WriterName.Contains("a") select x).Count().ToString();
            ViewBag.a1 = aharfi;

            var durumtrue = Convert.ToInt32(db.Categories.Count(x => x.CategoryStatus == true));
            var durumfalse = Convert.ToInt32(db.Categories.Count(x => x.CategoryStatus == false));
            int sonuc = durumtrue - durumfalse;
            ViewBag.goster = sonuc;







            return View();
        }
    }
}