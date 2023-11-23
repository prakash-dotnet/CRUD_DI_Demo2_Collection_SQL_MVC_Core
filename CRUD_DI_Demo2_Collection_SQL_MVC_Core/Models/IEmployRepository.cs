namespace CRUD_DI_Demo2_Collection_SQL_MVC_Core.Models
{
    public interface IEmployRepository
    {
        IEnumerable<Employee> GetAllEmployees();
        Employee GetEmployeeById(int id);
        int AddEmployee(Employee emp);
        void UpdateEmployee(Employee emp);
        void DeleteEmployee(int id);

    }
}
