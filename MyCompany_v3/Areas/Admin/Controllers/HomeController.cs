using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyCompany_v3.Domain;

namespace MyCompany_v3.Areas.Admin.Controllers
{
    [Area("Admin")] // указать, чтобы соглашение AdminArea вступило в силу
    public class HomeController : Controller
    {
        private readonly DataManager dataManager;

        public HomeController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
        public IActionResult Index()
        {
            return View(dataManager.ServiceItems.GetServiceItems());
        }
    }
}
