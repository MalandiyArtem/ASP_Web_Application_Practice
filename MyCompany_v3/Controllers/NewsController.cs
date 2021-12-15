using Microsoft.AspNetCore.Mvc;
using MyCompany_v3.Domain;
using System;

namespace MyCompany_v3.Controllers
{
    public class NewsController : Controller
    {
        private readonly DataManager dataManager;

        public NewsController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult Index(Guid id)
        {
            ViewBag.NewsField = dataManager.NewsItems.GetNewsItemByCodeWord("PageNews");
            return View(dataManager.NewsItems.GetNewsItems());
        }
    }
}
