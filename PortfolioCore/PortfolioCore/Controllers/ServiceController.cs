using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;
using PortfolioCore.Entities;

namespace PortfolioCore.Controllers
{
    public class ServiceController : Controller
    {
        PortfolioContext context=new PortfolioContext();

        public IActionResult ServicesList()
        {
            var values=context.Services.ToList();   
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateServices() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateServices(Service service)
        {
            var value = context.Services.Add(service);
            context.SaveChanges();
            return RedirectToAction("ServicesList");
        }
        public IActionResult DeleteServices(int id) 
        { 
            var value = context.Services.Find(id);
            context.Services.Remove(value);
            context.SaveChanges();
            return RedirectToAction("ServicesList");
        }

        [HttpGet]
        public IActionResult UpdateServices(int id) 
        { 
            var value=context.Services.Find(id);    
            return View(value);

        }

        [HttpPost]
        public IActionResult UpdateServices(Service service)
        {
            var value=context.Services.Update(service);
            context.SaveChanges();
            return RedirectToAction("ServicesList");
        }
    }
}
