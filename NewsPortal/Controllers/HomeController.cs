using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Json.Net;
using NewsPortal.Models;
using Newtonsoft.Json;

namespace NewsPortal.Controllers
{
    public class HomeController : Controller
    {
        NewsContext db = new NewsContext();
        public ActionResult Index()
        {
            IEnumerable<News> news = db._News;
            ViewBag.News = news;
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(News news)
        {
            db._News.Add(news);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}