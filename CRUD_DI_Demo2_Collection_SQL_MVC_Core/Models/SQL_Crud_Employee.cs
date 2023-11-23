namespace CRUD_DI_Demo2_Collection_SQL_MVC_Core.Models
{
    public class SQL_Crud_Employee : IEmployRepository
    {
        private readonly EmployDbContext _context;
        public SQL_Crud_Employee(EmployDbContext context)
        {
            _context = context;
        }
        public int AddEmployee(Employee emp)
        {
            _context.Employees.Add(emp);
            int res = _context.SaveChanges();
            if (res != 0)
                return res;
            else
                return 0;
        }

        public void DeleteEmployee(int id)
        {
            var emp = _context.Employees.Find(id);
            var res = _context.Employees.Remove(emp);
            _context.SaveChanges();
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _context.Employees.ToList();
        }

        public Employee GetEmployeeById(int id)
        {
            return _context.Employees.FirstOrDefault(e => e.Id == id);
        }

        public void UpdateEmployee(Employee emp)
        {
            _context.Employees.Update(emp);
            _context.SaveChanges();
        }
    }

}
