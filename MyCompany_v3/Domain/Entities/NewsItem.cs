using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany_v3.Domain.Entities
{
    public class NewsItem : EntityBase
    {
        [Required(ErrorMessage = "Fill the header of service")]
        [Display(Name = "Header of news")]
        public override string Title { get; set; }

        [Required] public string CodeWord { get; set; } = "News";

        [Display(Name = "Content")]
        public override string Text { get; set; }
    }
}
