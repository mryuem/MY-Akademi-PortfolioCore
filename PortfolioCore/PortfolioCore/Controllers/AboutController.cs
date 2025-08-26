﻿using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;
using PortfolioCore.Entities;

namespace PortfolioCore.Controllers
{
    public class AboutController : Controller
    {
        PortfolioContext context =new PortfolioContext();
        public IActionResult AboutList()
        {
           var values =context.Abouts.ToList();
            return View(values);
        }

 

        [HttpGet]
        public IActionResult UpdateAbout(int id) 
        {
                var value= context.Abouts.Find(id); 
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateAbout(About about)
        {
            var value=context.Abouts.Update(about);
            context.SaveChanges();
            return RedirectToAction("AboutList");
        }
    }
}
