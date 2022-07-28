namespace WebApplication2.Models
{
    public class DbManager
    {
        public static List<employee> empList;

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

        public void AddEmp(employee e1)
        {
            empList.Add(e1);
        }
        public employee GetDetailsByID(int Id)
        {
            return empList.Find(item => item.Id == Id);
        }
        public void DeleteEmp(int Id)
        {
            employee e1 = empList.Find(item => item.Id == Id);
            empList.Remove(e1);
        }
        public void UpdateEmp(employee updatedobj)
        {
            employee oldobj = empList.Find(item => item.Id == updatedobj.Id);
            empList.Remove(oldobj);
            empList.Add(updatedobj);
        }
    }
}