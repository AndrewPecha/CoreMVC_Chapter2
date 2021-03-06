﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewData["Greeting"] = hour < 12 ? "Good Morning" : "Good Afternoon";

            return View("MyView");            
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse response)
        {
            if (ModelState.IsValid)
            {
                Repository.AddResponse(response);
                return View("Thanks", response);
            }
            else
            {
                return View();
            }            
        }

        public ViewResult ListResponses()
        {
            return View(Repository.Responses.Where(response => response.WillAttend == true));
        }
    }
}
