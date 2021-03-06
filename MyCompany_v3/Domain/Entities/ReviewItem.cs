using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        [Required(ErrorMessage = "Title is required")]
        [Display(Name = "Name (Title)")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Content is required")]
        [Display(Name = "Full description")]
        public string Text { get; set; }

        [ForeignKey("UserId")]
        public string UserId { get; set; }

        [DataType(DataType.Time)]
        public DateTime DateAdded { get; set; }
    }
}
