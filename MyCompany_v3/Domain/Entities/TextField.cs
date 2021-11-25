using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany_v3.Domain.Entities
{
    public class TextField : EntityBase
    {
        [Required]
        public string CodeWord { get; set; }

        [Display(Name = "Name of page (title)")]
        public override string Title { get; set; } = "Information page";

        [Display(Name = "Content of page")] 
        public override string Text { get; set; } = "Content fills by admin";
    }
}
