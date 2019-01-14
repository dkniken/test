using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using btMVC3.Models;
namespace btMVC3.Controllers
{
    public class Bt1Controller : Controller
    {
        //
        // GET: /Bt1/
        [HttpGet]
        public ActionResult Baitap()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Baitap(FormCollection form)

        {
            var ten = form["txtHoten"];
            ViewBag.ten = ten;
            var gt = form["gt"]=="Nam"?"Anh":"Chị";
            ViewBag.gt = gt;
            string ntns = form["NTNS"];
            ViewBag.ntns = ntns;
            var st = form["st"];
            st = st.ToLower();
            ViewBag.st = st;
            var state = form["state"];
            ViewBag.state = state;

            ViewBag.kq = gt + " " + ten + " sinh ngày " +ntns+ " có sở thích " + st + " hiện đang aqq" + state;
            return View();
        }

    }
}
