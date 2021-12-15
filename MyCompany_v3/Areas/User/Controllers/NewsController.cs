using Microsoft.AspNetCore.Mvc;
using MyCompany_v3.Domain;
using System;

namespace MyCompany_v3.Areas.User.Controllers
{
    [Area("User")]
    public class NewsController : Controller
    {
        private readonly DataManager dataManager;

        public NewsController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult Index(Guid id)
        {
            ViewBag.IsAdmin = User.IsInRole("admin");

            GetUserName();
            ViewBag.NewsField = dataManager.NewsItems.GetNewsItemByCodeWord("PageNews");
            return View(dataManager.NewsItems.GetNewsItems());
        }

        private void GetUserName()
        {
            ViewBag.UserName = User.Identity.Name;
        }
    }
}
