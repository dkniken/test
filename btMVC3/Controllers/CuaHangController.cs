using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using btMVC3.Models;

namespace btMVC3.Controllers
{
    public class CuaHangController : Controller
    {
        BanBuonEntities db = new BanBuonEntities();

        public ActionResult Xem()
        {
            return View(db.SanPhams.ToList());
        }

        public ActionResult Chitiet(string ma)
        {
            SanPham sp = db.SanPhams.SingleOrDefault(x => x.Ma == ma);
            return View(sp);
        }
        public ActionResult Xoa(string ma)
        {
            SanPham sp = db.SanPhams.SingleOrDefault(x => x.Ma == ma);
            db.SanPhams.Remove(sp);
            db.SaveChanges();
            return RedirectToAction("Xem");
        }

        [HttpGet]
        public ActionResult Them()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Them(SanPham sp,FormCollection form)
        {
            db.SanPhams.Add(sp);
            db.SaveChanges();

            return RedirectToAction("Xem");
        }

    }
}
