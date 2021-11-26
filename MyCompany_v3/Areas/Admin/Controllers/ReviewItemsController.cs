using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using MyCompany_v3.Domain;
using MyCompany_v3.Domain.Entities;
using MyCompany_v3.Models;
using MyCompany_v3.Services;

namespace MyCompany_v3.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ReviewItemsController : Controller
    {
        private readonly DataManager dataManager;
        private readonly UserManager<IdentityUser> _userManager;
        public ReviewItemsController(DataManager dataManager, UserManager<IdentityUser> _userManager)
        {
            this.dataManager = dataManager;
            this._userManager = _userManager;
        }
        public IActionResult Index(Guid id)
        {
            IQueryable<ReviewViewModel> userReview = from view in dataManager.ReviewItems.GetReviewsItems()
                join user in _userManager.Users
                    on view.UserId equals user.Id
                select new ReviewViewModel()
                {
                    Id = view.Id,
                    Title = view.Title,
                    Text = view.Text,
                    UserId = user.Id,
                    UserName = user.UserName
                };

            if (id != default)
            {
                return View("Show", dataManager.ReviewItems.GetReviewItemById(id));
            }
            return View(userReview);
        }

        public IActionResult Delete(Guid id)
        {
            dataManager.ReviewItems.DeleteReviewItem(id);
            return RedirectToAction(nameof(ReviewItemsController.Index), nameof(ReviewItemsController).CutController());
        }
    }
}
