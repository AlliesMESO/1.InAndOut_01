﻿using Microsoft.AspNetCore.Mvc;

namespace _1.InAndOut_01.Controllers
{
    public class AppointmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
            //string todaysDate = DateTime.Now.ToShortDateString();
            //return Ok(todaysDate);
        }

        public IActionResult Details(int id)
        {
            return Ok("You have entered id = " + id);
        }
    }
}
