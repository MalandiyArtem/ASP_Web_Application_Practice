using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace MyCompany_v3.Models
{
    public class MessageViewModel
    {
        public Guid Id { get; set; }

        [Display(Name = "Title")]
        public string Title { get; set; }

        [Display(Name = "Content")]
        public string Text { get; set; }

        public string UserId { get; set; }

        public string UserName { get; set; }

        public bool IsFeedback { get; set; }
    }
}
