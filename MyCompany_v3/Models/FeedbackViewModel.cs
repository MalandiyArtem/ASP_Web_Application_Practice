using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany_v3.Models
{
    public class FeedbackViewModel
    {
        public Guid FeedbackId { get; set; }

        public Guid ReviewId { get; set; }

        public string Title { get; set; }

        public string Text { get; set; }

        public string UserId { get; set; }

        public string UserName { get; set; }
    }
}
