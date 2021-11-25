using Microsoft.AspNetCore.Mvc;
using MyCompany_v3.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            //if (id != default)
            //    return View("Show", dataManager.NewsItems.GetNewsItemById(id));

            ViewBag.NewsField = dataManager.NewsItems.GetNewsItemByCodeWord("PageNews");
            return View(dataManager.NewsItems.GetNewsItems());
        }
    }
}
