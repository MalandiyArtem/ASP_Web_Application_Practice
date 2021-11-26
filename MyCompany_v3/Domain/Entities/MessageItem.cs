using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace MyCompany_v3.Domain.Entities
{
    public class MessageItem
    {
        public MessageItem()
        {
            CreationDate = DateTime.UtcNow;
            Id = Guid.NewGuid();
        }

        [Required]
        [Key]
        public Guid Id { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }

        [Display(Name = "Title")]
        public string Title { get; set; }

        [Display(Name = "Content")]
        public string Text { get; set; }

        [ForeignKey("UserId")]
        public string UserId { get; set; }

        public IdentityUser User { get; set; }
    }
}
