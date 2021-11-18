using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstWebApplication.Controlers
{
    public class GameController : Controller
    {
        
        public IActionResult GuessingGame()
        {
            Random rnd = new Random();
            int n = rnd.Next(1, 100);
            HttpContext.Session.SetInt32("rndNumber",n);
            return View();
        }
        [HttpPost]
        public IActionResult GuessingGame(string txtGame)
        {
            int x = int.Parse(txtGame);
            if (x >= 1 && x <= 100)
            {
               
                if (HttpContext.Session.IsAvailable)
                {
                    int n = Convert.ToInt32(HttpContext.Session.GetInt32("rndNumber"));

                    if (n == 0)
                    {
                        ViewBag.info = "Session expired.please refresh the page";
                    }
                    if (x == n)
                    {
                        ViewBag.info = "Congrats, you won the game";
                        Random rnd = new Random();
                        HttpContext.Session.SetInt32("rndNumber", rnd.Next(1, 100));
                    }
                    else if (x > n)
                        ViewBag.info = "Sorry, Given value greater to ganarated value";
                    else// (x < n)
                        ViewBag.info = "Sorry, Given value lesser to ganarated value";


                }
                else
                    ViewBag.info = "Value must be in 1-100";
            }
            else
            {
                ViewBag.info = "Session expaired";
            }
            return View();
        }
    }
}
