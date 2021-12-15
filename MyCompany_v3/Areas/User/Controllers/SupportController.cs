using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using MyCompany_v3.Domain;
using MyCompany_v3.Domain.Entities;
using MyCompany_v3.Services;

namespace MyCompany_v3.Areas.User.Controllers
{
    [Area("User")]
    public class SupportController : Controller
    {
        private readonly DataManager dataManager;
        public SupportController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
        public IActionResult WriteMessage()
        {
            GetUserName();
            ViewBag.IsAdmin = User.IsInRole("admin");
            ViewBag.UserId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var entity = new MessageItem();
            return View(entity);
        }

        [HttpPost]
        public IActionResult WriteMessage(MessageItem model)
        {
            if (ModelState.IsValid)
            {
                dataManager.MessageItems.SaveMessageItem(model);
                return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
            }
            return View(model);
        }

        private void GetUserName()
        {
            ViewBag.UserName = User.Identity.Name;
        }
    }
}
