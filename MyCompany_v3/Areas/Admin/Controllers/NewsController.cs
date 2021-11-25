﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            return View(dataManager.NewsItems.GetNewsItems());
        }

        private void GetUserName()
        {
            ViewBag.UserName = User.Identity.Name;
        }
    }
}