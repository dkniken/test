using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using btMVC3.Models;
namespace btMVC3.Controllers
{
    public class HinhHocController : Controller
    {
        //
        // GET: /HinhHoc/
        [HttpGet]
        public ActionResult ChuNhat()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult ChuNhat(FormCollection form)
        {
            int dai = Int32.Parse(form["dai"]);
            ViewBag.dai = dai;
            int rong = Int32.Parse(form["rong"]);
            ViewBag.rong = rong;
            string tinh = form["tinh"];
            ViewBag.tinh = tinh;
            if(tinh.IndexOf("cv")!=-1)
            {
                ViewBag.chuvi = (dai+rong)*2;
                
            }
           
            if (tinh.IndexOf("dt")!=-1)
            {
                ViewBag.dientich = dai*rong;
                
            }
           

            return View();
        }

    }
}
