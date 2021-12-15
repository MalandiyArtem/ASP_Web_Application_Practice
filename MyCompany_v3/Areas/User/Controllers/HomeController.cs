using Microsoft.AspNetCore.Mvc;
using MyCompany_v3.Domain;

namespace MyCompany_v3.Areas.User.Controllers
{
    [Area("User")]
    public class HomeController : Controller
    {
        private readonly DataManager dataManager;
        

        public HomeController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
        public IActionResult Index()
        {
            ViewBag.IsAdmin = User.IsInRole("admin");
            GetUserName();
            return View(dataManager.TextFields.GetTextFieldByCodeWord("PageIndex"));
        }

        public IActionResult Contacts()
        {
            ViewBag.IsAdmin = User.IsInRole("admin");
            GetUserName();
            return View(dataManager.TextFields.GetTextFieldByCodeWord("PageContacts"));
        }

        private void GetUserName()
        {
            ViewBag.UserName = User.Identity.Name;
        }
    }
}
