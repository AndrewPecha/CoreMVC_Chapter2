using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        { int[] array = { 1, 2, 3 };

            ViewBag.BagThing = array;
            ViewData["DataThing"] = array;

            return View("MyView");
            
        }
    }
}
