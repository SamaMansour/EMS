namespace EMS_project.Models
{
    public class RequestVacation :EntityBase
    {
        public int EmployeeId { get; set; }
        public Employee? Employee { get; set; }

        public DateTime? RequestDate { get; set; }

        public int VacationTypeId { get; set; }


        public VacationType MyProperty { get; set; }

    }
}
