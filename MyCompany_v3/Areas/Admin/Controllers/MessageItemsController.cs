using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using MyCompany_v3.Domain;
using MyCompany_v3.Models;
using MyCompany_v3.Services;

namespace MyCompany_v3.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MessageItemsController : Controller
    {
        private readonly DataManager dataManager;
        private readonly UserManager<IdentityUser> _userManager;
        public MessageItemsController(DataManager dataManager, UserManager<IdentityUser> _userManager)
        {
            this.dataManager = dataManager;
            this._userManager = _userManager;
        }
        public IActionResult Index(Guid id)
        {
            IQueryable<MessageViewModel> userMessage = from msg in dataManager.MessageItems.GeMessageItems()
                join user in _userManager.Users 
                    on msg.UserId equals user.Id
                    orderby msg.CreationDate descending
                select new  MessageViewModel()
                {
                    Id = msg.Id,
                    Title = msg.Title,
                    Text = msg.Text,
                    UserId = user.Id,
                    UserName = user.UserName
                };

            if (id != default)
            {
                return View("Show", dataManager.MessageItems.GeMessageItemById(id));
            }
            return View(userMessage);
        }

        public IActionResult Delete(Guid id)
        {
            dataManager.MessageItems.DeleteMessageItem(id);
            return RedirectToAction(nameof(MessageItemsController.Index), nameof(MessageItemsController).CutController());
        }
    }
}
