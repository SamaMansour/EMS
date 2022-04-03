using System.ComponentModel.DataAnnotations;

namespace EMS_project.Models
{
    public class VacationType :EntityBase
    {
        [StringLength(200)]
        [Display(Name = "Vacation Name")]

        public string VacationName { get; set; } = string.Empty;

        [Display(Name = "Vacation Color")]
        [StringLength(7)]
        public string backgroundColor { get; set; }

        [Display(Name = "Number Days")]
        public int NumberDays { get; set; }
    }
}
