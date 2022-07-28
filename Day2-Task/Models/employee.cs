using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
namespace WebApplication2.Models
{
    public class employee
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string job { get; set; }

        public int sal { get; set; }
        public int deptid { get; set; }
    }
    public class EmployeeDbContext : DbContext
    {
        public DbSet<employee> Employees { get; set; }

        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options)
         : base(options)
        {

        }
    }
}


    


