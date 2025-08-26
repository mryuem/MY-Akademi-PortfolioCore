using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PortfolioCore.Context;

namespace PortfolioCore.ViewComponents
{
    public class _DefaultPortfolioComponentPartial:ViewComponent
    {
        PortfolioContext context=new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values=context.Portfolios.ToList();
            return View(values);
        }

        public IViewComponentResult ListByCategory(int id) 
        {
            var values=context.Portfolios.Include(x=>x.Category).Where(x=>x.CategoryId==id).ToList();   
            return View(values);    
        }
    }
}
