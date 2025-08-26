using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;
using PortfolioCore.Entities;

namespace PortfolioCore.Controllers
{
    public class SendMessageController : Controller
    {
        PortfolioContext context=new PortfolioContext();

        [HttpPost]
        public IActionResult SendMessage(Message message)
        {
            context.Messages.Add(message);
            context.SaveChanges();
            ViewBag.msgAlert = "Mesaj başarılı bir şekilde gönderildi";
            return View("~/Views/Default/Index.cshtml");
        }
    }
}
