using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using MyCompany_v3.Domain;
using MyCompany_v3.Models;
using MyCompany_v3.Services;

namespace MyCompany_v3.Areas.User.Controllers
{
    [Area("User")]
    public class ResultReviewController : Controller
    {
        private readonly DataManager dataManager;
        private readonly UserManager<IdentityUser> _userManager;
        public ResultReviewController(DataManager dataManager, UserManager<IdentityUser> _userManager)
        {
            this.dataManager = dataManager;
            this._userManager = _userManager;
        }
        public IActionResult Index(Guid id)
        {
            ClaimsPrincipal currentUser = this.User;
            string UserId = currentUser.FindFirst(ClaimTypes.NameIdentifier).Value;

            IQueryable<FeedbackViewModel> userMessage = from msg in dataManager.FeedbackItems.GetFeedbackItems()
                join user in _userManager.Users
                    on msg.UserId equals user.Id
                where user.Id == msg.UserId
                select new FeedbackViewModel()
                {
                    FeedbackId = msg.Id,
                    Title = msg.Title,
                    Text = msg.Text,
                    UserId = user.Id,
                    UserName = user.UserName
                };

            if (id != default)
            {
                return View("Show", dataManager.FeedbackItems.GetFeedbackItemById(id));
            }
            return View(userMessage);
        }

        public IActionResult Delete(Guid id)
        {
            dataManager.FeedbackItems.DeleteFeedbackItem(id);
            return RedirectToAction(nameof(ResultReviewController.Index), nameof(ResultReviewController).CutController());
        }
    }
}
