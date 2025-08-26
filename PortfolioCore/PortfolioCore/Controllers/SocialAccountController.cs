using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PortfolioCore.Context;
using PortfolioCore.Entities;

namespace PortfolioCore.Controllers
{
    public class SocialAccountController : Controller
    {
        PortfolioContext context=new PortfolioContext();
        public IActionResult SocialAccountList()
        {
            var values = context.SocialAccounts.Include(x=>x.Icon).ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateSocialAccount()
        {
           var values=new SelectList(context.Icons.ToList(),"IconId","IconName");
            ViewBag.v=values;
            return View();
        }
        [HttpPost]
        public IActionResult CreateSocialAccount(SocialAccount socialAccount)
        {
            
            var value=context.SocialAccounts.Add(socialAccount);
            context.SaveChanges();
            return RedirectToAction("SocialAccountList");
        }

        public IActionResult DeleteSocialAccount(int id)
        { 
            var value=context.SocialAccounts.Find(id);
            context.SocialAccounts.Remove(value);
            context.SaveChanges();
            //if (value != null) 
            //{
            //    value.Status = false;
            //    context.SaveChanges();
                
            //}
            return RedirectToAction("SocialAccountList");
        }


        [HttpGet]
        public IActionResult UpdateSocialAccount(int id)
        {
            var value = context.SocialAccounts.Find(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateSocialAccount(SocialAccount socialAccount)
        {
           

        var value=context.SocialAccounts.Find(socialAccount.SocialAccountId);
            if(value == null) return NotFound();

            value.SocialUrl=socialAccount.SocialUrl;
            context.SaveChanges();
            return RedirectToAction("SocialAccountList");


        }
    }
}
