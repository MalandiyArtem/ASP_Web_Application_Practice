using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyCompany_v3.Domain.Entities
{
    public class FeedbackItem
    {
        public FeedbackItem()
        {
            CreationDate = DateTime.UtcNow;
            Id = Guid.NewGuid();
        }

        [Required]
        [Key]
        public Guid Id { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }

        [Required (ErrorMessage = "Title is required")]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Content is required")]
        [Display(Name = "Content")]
        public string Text { get; set; }

        public string UserId { get; set; }

        [ForeignKey("ReviewId")]
        public Guid ReviewId { get; set; }
    }
}
