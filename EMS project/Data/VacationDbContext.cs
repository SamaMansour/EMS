using EMS_project.Models;
using Microsoft.EntityFrameworkCore;

namespace EMS_project.Data
{
    public class VacationDbContext :DbContext
    {
        public VacationDbContext(DbContextOptions <VacationDbContext> options) :base(options)
        {

        }

        public DbSet<Department> Departments { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<VacationType> VacationTypes { get; set; }

        public DbSet<RequestVacation> RequestVacations { get; set; }

        public DbSet<VacationPlan> vacationPlans { get; set; }



    }
}
