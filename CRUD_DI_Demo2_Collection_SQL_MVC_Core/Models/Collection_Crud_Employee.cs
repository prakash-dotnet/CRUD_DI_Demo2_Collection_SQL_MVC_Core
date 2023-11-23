namespace CRUD_DI_Demo2_Collection_SQL_MVC_Core.Models
{
     public class Collection_Crud_Employee : IEmployRepository
    {
        static List<Employee> employees = new List<Employee>();

        static Collection_Crud_Employee()
        {
            Employee emp1 = new Employee();
            emp1.Id = 1;
            emp1.Name = "Alekya";
            emp1.Department = "Dev";
            emp1.Salary = 10000;

            Employee emp2 = new Employee();
            emp2.Id = 2;
            emp2.Name = "Ram";
            emp2.Department = "UI";
            emp2.Salary = 20000;

            Employee emp3 = new Employee();
            emp3.Id = 3;
            emp3.Name = "surya";
            emp3.Department = "HR";
            emp3.Salary = 21000;

            Employee emp4 = new Employee();
            emp4.Id = 4;
            emp4.Name = "chandra";
            emp4.Department = "UI";
            emp4.Salary = 11900;

            employees.Add(emp1);
            employees.Add(emp2);
            employees.Add(emp3);
            employees.Add(emp4);

        }
        public int AddEmployee(Employee emp)
        {

            employees.Add(emp);
            return 1;
        }

        public void DeleteEmployee(int id)
        {

            employees.RemoveAll(s => s.Id == id);
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return employees;
        }

        public Employee GetEmployeeById(int id)
        {
            return employees.FirstOrDefault(s => s.Id == id);
        }

        public void UpdateEmployee(Employee emp)
        {
            var index = employees.FindIndex(s => s.Id == emp.Id);

            var empl = employees[index];
            empl.Name = emp.Name;
            empl.Department = emp.Department;

            empl.Salary = emp.Salary;
            employees[index] = empl;
        }
    } 
}
