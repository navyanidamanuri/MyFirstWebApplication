using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyFirstWebApplication.Models;

namespace MyFirstWebApplication.Controlers
{
    public class DocterController : Controller
    {
       
        public ActionResult CheckFever()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CheckFever(string txtTemp)
        {

            int temp = int.Parse(txtTemp);
            ViewBag.msg = Utility.CheckTemparature(temp);
            
            return View();
        }
        

    }
}
