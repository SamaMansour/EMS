using System.ComponentModel.DataAnnotations;

namespace EMS_project.Models
{
    public class Department : EntityBase
    {
        

        [Display(Name ="Department Name")]
        [StringLength(150)]
        public string Name { get; set; }

        public string Description { get; set; }


    }

   
}
