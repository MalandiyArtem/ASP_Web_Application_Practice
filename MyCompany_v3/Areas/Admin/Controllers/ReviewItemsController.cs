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
                    orderby view.DateAdded descending
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
                var review = dataManager.ReviewItems.GetReviewItemById(id);
                var feedbackItem = new FeedbackItem()
                {
                    ReviewId = review.Id,
                    UserId = review.UserId,
                    Title = review.Title,
                    Text = review.Text
                };

                return View("Show", feedbackItem);
            }
            return View(userReview);
        }

        [HttpPost]
        public IActionResult ReviewControl(FeedbackItem model, string reviewControl)
        {
            if (ModelState.IsValid)
            {
                if (reviewControl == "Decline")
                {
                    dataManager.FeedbackItems.SaveFeedbackItem(model);
                    Delete(model.ReviewId);
                    return RedirectToAction(nameof(Index), nameof(ReviewItemsController).CutController());
                }
                if (reviewControl == "Approve")
                {
                    dataManager.FeedbackItems.SaveFeedbackItem(model);

                    var review = dataManager.ReviewItems.GetReviewItemById(model.ReviewId);

                    var news = new NewsItem()
                    {
                        Title = review.Title,
                        Text = review.Text
                    };
                    dataManager.NewsItems.SaveNewsItem(news);
                    return RedirectToAction(nameof(Index), nameof(ReviewItemsController).CutController());
                }
            }
            return RedirectToAction(nameof(Index), nameof(ReviewItemsController).CutController(), new { id = model.ReviewId });
        }
        
        private void Delete(Guid id)
        {
            dataManager.ReviewItems.DeleteReviewItem(id);
        }
    }
}
