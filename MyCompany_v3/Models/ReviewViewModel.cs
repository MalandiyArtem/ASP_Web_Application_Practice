using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany_v3.Models
{
    public class ReviewViewModel
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Text { get; set; }

        public string UserId { get; set; }

        public string UserName { get; set; }
    }
}
