using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany_v3.Domain.Entities
{
    public class ReviewItem
    {
        public ReviewItem()
        {
            DateAdded = DateTime.UtcNow;
            Id = Guid.NewGuid();
        }

        [Key]
        [Required]
        public Guid Id { get; set; }

        [Display(Name = "Name (Title)")]
        public string Title { get; set; }

        [Display(Name = "Full description")]
        public string Text { get; set; }

        [ForeignKey("UserId")]
        public string UserId { get; set; }

        [DataType(DataType.Time)]
        public DateTime DateAdded { get; set; }
    }
}
