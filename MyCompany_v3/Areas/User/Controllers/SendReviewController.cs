using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
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
            ViewBag.IsAdmin = User.IsInRole("admin");
            string currentUserId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var entity = new ReviewItem()
            {
                UserId = currentUserId
            };
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
