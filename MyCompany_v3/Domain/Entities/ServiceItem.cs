using System.ComponentModel.DataAnnotations;

namespace MyCompany_v3.Domain.Entities
{
    public class ServiceItem : EntityBase
    {
        [Required(ErrorMessage = "Fill the name of service")] 
        [Display(Name = "Name of service")]
        public override string Title { get; set; }

        [Display(Name = "Brief description of service")]
        public override string Subtitle { get; set; }

        [Display(Name = "Full description of service")]
        public override string Text { get; set; }
    }
}
