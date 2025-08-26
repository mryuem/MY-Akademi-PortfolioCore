using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;

namespace PortfolioCore.Controllers
{
    public class IconController : Controller
    {
        PortfolioContext context=new PortfolioContext();

        public IActionResult IconList()
        {
            var values=context.Icons.ToList();
            return View(values);
        }
    }
}
