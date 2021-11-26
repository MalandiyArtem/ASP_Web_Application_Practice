using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
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
            ClaimsPrincipal currentUser = this.User;
            ViewBag.UserId = currentUser.FindFirst(ClaimTypes.NameIdentifier).Value;
            var entity = new MessageItem();
            return View(entity);
        }

        [HttpPost]
        public IActionResult WriteMessage(MessageItem model)
        {
            if (ModelState.IsValid)
            {
                dataManager.MessageItems.SaveMessageItem(model);
                return RedirectToAction(nameof(SupportController.WriteMessage), nameof(SupportController).CutController());
            }
            return View(model);
        }
    }
}
