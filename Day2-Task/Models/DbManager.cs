namespace WebApplication2.Models
{
    public class DbManager
    {
        public static List<employee> empList = new List<employee>();

        public DbManager()
        {
            empList = new List<employee>() {
                new employee(){ Id=1011,Name="Jack",job="SoftwareEngineer",sal=90000,deptid=1},
                new employee(){ Id=1012,Name="Joe",job="SoftwareEngineer",sal=27000,deptid=2},
                new employee(){ Id=1013,Name="Luke",job="IT Trainee",sal=25000,deptid=5},
                new employee(){ Id=1014,Name="Jay",job="Intern",sal=9000,deptid=5},
            };
        }

        public List<employee> GetAllDetails()
        {
            return empList;
        }

        public void addemployee(employee obj)
        {
            empList.Add(obj);
        }
        public employee GetDetailsByID(int id)
        {
            return empList.Find(item => item.Id == id);
        }
        public void DeleteEmp(int id)
        {
            employee e1 = empList.Find(item => item.Id == id);
            empList.Remove(e1);
        }
        public void Updatelist(employee details)
        {
            employee oldobj = empList.Find(item => item.Id == details.Id);
            empList.Remove(oldobj);
            empList.Add(details);      }
    }
}