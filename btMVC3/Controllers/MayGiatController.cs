using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using btMVC3.Models;

namespace btMVC3.Controllers
{
    public class MayGiatController : Controller
    {
        //
        // GET: /MayGiat/
        BaiThiEntities db = new BaiThiEntities();
        public ActionResult Xem()
        {

            return View(db.MayGiats.ToList());
        }
        public ActionResult Xoa(int ma)
        {
            MayGiat mg = db.MayGiats.SingleOrDefault(x => x.Ma == ma);
            db.MayGiats.Remove(mg);
            db.SaveChanges();
            return RedirectToAction("Xem");
        }
        [HttpGet]
        public ActionResult Them()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Them(MayGiat mg)
        {
            db.MayGiats.Add(mg);
            db.SaveChanges();
            return RedirectToAction("Xem");
        }
        [HttpGet]
        public ActionResult Sua(int ma)
        {
            MayGiat mg = db.MayGiats.SingleOrDefault(x => x.Ma == ma);
            return View(mg);
        }
        [HttpPost]
        public ActionResult Sua(MayGiat mg)
        {
            db.Entry(mg).State = System.Data.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Xem");
        }

    }
}
