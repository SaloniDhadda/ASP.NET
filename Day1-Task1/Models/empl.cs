namespace WebApplication2.Models
{
    public class empl
    {
        public List<Employee> emplist { get; set; }
    }

        public partial class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public string job { get; set; } 

            public string Department { get; set; }

            public int Salary { get; set; }
        public int deptid { get; set; }
    }
    }

