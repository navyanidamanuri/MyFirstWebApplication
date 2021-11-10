using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstWebApplication.Controlers
{
    public class DocterController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CheckFever()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CheckFever(string txtTemp)
        {

            int temp = int.Parse(txtTemp);
            if (temp >= 100)
                ViewBag.msg = "Person having Fever";
            if (temp < 100)
                ViewBag.msg = "Person having  no Fever";
            return View();
        }

    }
}
