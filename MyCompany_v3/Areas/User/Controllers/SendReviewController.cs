using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using MyCompany_v3.Domain;
using MyCompany_v3.Domain.Entities;
using MyCompany_v3.Services;

namespace MyCompany_v3.Areas.User.Controllers
{
    [Area("User")]
    public class SendReviewController : Controller
    {
        private readonly DataManager dataManager;
        private readonly UserManager<IdentityUser> _userManager;
        public SendReviewController(DataManager dataManager, UserManager<IdentityUser> _userManager)
        {
            this.dataManager = dataManager;
            this._userManager = _userManager;
        }
        public IActionResult Send()
        {
            ClaimsPrincipal currentUser = this.User;
            ViewBag.UserId = currentUser.FindFirst(ClaimTypes.NameIdentifier).Value;
            var entity = new ReviewItem();
            return View(entity);
        }

        [HttpPost]
        public IActionResult Send(ReviewItem model)
        {
            if (ModelState.IsValid)
            {
                dataManager.ReviewItems.SaveReviewItem(model);
                return RedirectToAction(nameof(NewsController.Index), nameof(NewsController).CutController());
            }

            return View(model);
        }
    }
}
