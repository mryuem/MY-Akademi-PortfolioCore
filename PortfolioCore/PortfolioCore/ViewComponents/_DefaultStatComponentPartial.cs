using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace PortfolioCore.ViewComponents
{
    public class _DefaultStatComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Random rnd = new Random();
            ViewBag.v0=rnd.Next(10,21);
            ViewBag.v1=rnd.Next(10,21);
            ViewBag.v2=rnd.Next(10,21);
            ViewBag.v3=rnd.Next(10,21);


            return View();
        }


    }
}
