using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using btMVC3.Models;

namespace btMVC3.Controllers
{
    public class NhanVienController : Controller
    {
        //
        // GET: /NhanVien/
        BanBuonEntities db = new BanBuonEntities();
        public ActionResult Xem()
        {
            return View(db.NhanViens.ToList());
        }
        public ActionResult ChiTiet(int ma)
        {
            NhanVien nv = db.NhanViens.SingleOrDefault(x => x.Ma == ma);
            return View(nv);
        }
        public ActionResult Xoa(int ma)
        {
            NhanVien nv = db.NhanViens.SingleOrDefault(x => x.Ma == ma);
            db.NhanViens.Remove(nv);
            db.SaveChanges();
            return RedirectToAction("Xem");
        }
        [HttpGet]
        public ActionResult Them()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Them(NhanVien nv)
        {
            db.NhanViens.Add(nv);
            db.SaveChanges();
            return RedirectToAction("Xem");
        }
        [HttpGet]
        public ActionResult Sua(int ma)
        {
            NhanVien nv = db.NhanViens.SingleOrDefault(x => x.Ma == ma);
            return View(nv);
        }
        [HttpPost]
        public ActionResult Sua(NhanVien nv)
        {
            db.Entry(nv).State = System.Data.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Xem");
        }
    }
}
