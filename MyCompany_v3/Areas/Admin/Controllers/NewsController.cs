using Microsoft.AspNetCore.Mvc;
using System.Linq;
using MyCompany_v3.Domain;

namespace MyCompany_v3.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class NewsController : Controller
    {
        private readonly DataManager dataManager;

        public NewsController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult ManageNews()
        {
            GetUserName();
            return View(dataManager.NewsItems.GetNewsItems().OrderByDescending(n => n.DateAdded));
        }

        private void GetUserName()
        {
            ViewBag.UserName = User.Identity.Name;
        }
    }
}
