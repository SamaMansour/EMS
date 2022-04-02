using System.ComponentModel.DataAnnotations;

namespace EMS_project.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="Department Name")]
        [StringLength(150)]
        public string Name { get; set; }

        public string Description { get; set; }


    }
}
