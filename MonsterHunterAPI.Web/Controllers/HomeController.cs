using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MonsterHunterAPI.Domain.Services;

namespace MonsterHunterAPI.Web.Controllers
{
    public class HomeController : Controller
    {
       
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            System.Diagnostics.Debug.Write("ljflskdjf");
            


            return View();
        }


        void NEWAPP() { }
    }
}
