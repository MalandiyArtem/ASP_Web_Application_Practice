using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using MyCompany_v3.Domain;
using MyCompany_v3.Domain.Entities;
using MyCompany_v3.Services;

namespace MyCompany_v3.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class NewsItemsController : Controller
    {
        private readonly DataManager dataManager;
        public NewsItemsController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
        public IActionResult Edit(Guid id)
        {
            GetUserName();
            var entity = id == default ? new NewsItem() : dataManager.NewsItems.GetNewsItemById(id);
            return View(entity);
        }

        [HttpPost]
        public IActionResult Edit(NewsItem model)
        {
            GetUserName();
            if (ModelState.IsValid)
            {
                if (dataManager.NewsItems.GetNewsItems().Any(x => x.Title == model.Title))
                {
                    ViewBag.TitleIsExist = true;
                    return View(model);
                }

                dataManager.NewsItems.SaveNewsItem(model);
                return RedirectToAction(nameof(NewsController.ManageNews), nameof(NewsController).CutController());
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(Guid id)
        {
            GetUserName();
            dataManager.NewsItems.DeleteNewsItem(id);
            return RedirectToAction(nameof(NewsController.ManageNews), nameof(NewsController).CutController());
        }

        private void GetUserName()
        {
            ViewBag.UserName = User.Identity.Name;
        }
    }
}
