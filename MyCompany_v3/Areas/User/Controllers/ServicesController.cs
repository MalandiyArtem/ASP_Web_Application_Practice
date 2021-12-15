using Microsoft.AspNetCore.Mvc;
using System;
using MyCompany_v3.Domain;

namespace MyCompany_v3.Areas.User.Controllers
{
    [Area("User")]
    public class ServicesController : Controller
    {
        private readonly DataManager dataManager;

        public ServicesController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult Index(Guid id)
        {
            ViewBag.IsAdmin = User.IsInRole("admin");
            GetUserName();
            if (id != default)
                return View("Show", dataManager.ServiceItems.GetServiceItemById(id));

            ViewBag.TextField = dataManager.TextFields.GetTextFieldByCodeWord("PageServices");
            return View(dataManager.ServiceItems.GetServiceItems());
        }

        private void GetUserName()
        {
            ViewBag.UserName = User.Identity.Name;
        }
    }
}
