using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DigitalFaturamMVC.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult eFaturayaGecis()
        {
            return View();
        }
        public ActionResult eFaturaAvantaj()
        {
            return View();
        }
        public ActionResult eFaturaDepolama()
        {
            return View();
        }
        public ActionResult eFaturaNasilKullanilir()
        {
            return View();
        }
        public ActionResult OnMuhasebeNedir()
        {
            return View();
        }
    }
}