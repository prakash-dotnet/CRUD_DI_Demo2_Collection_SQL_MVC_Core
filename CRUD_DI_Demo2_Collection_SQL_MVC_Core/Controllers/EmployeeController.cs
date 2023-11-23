using CRUD_DI_Demo2_Collection_SQL_MVC_Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_DI_Demo2_Collection_SQL_MVC_Core.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ILogger<EmployeeController> _logger;
        private readonly IEmployRepository _Repository;
        public EmployeeController(ILogger<EmployeeController> logger, IEmployRepository Repository)
        {
            _logger = logger;
            _Repository = Repository;
        }
        public IActionResult AllEmployees()
        {
            List<Employee> emps = (List<Employee>)_Repository.GetAllEmployees();
            return View(emps);
        }
		public IActionResult Index()
		{
			List<Employee> emps = (List<Employee>)_Repository.GetAllEmployees();
			return View(emps);
		}
		public IActionResult DeleteEmployee(int id)
        {
            _Repository.DeleteEmployee(id);
            return RedirectToAction("AllEmployess");
        }
        public IActionResult AddEmployee()
        {



            return View();
        }
        [HttpPost]
        public IActionResult AddEmployee(Employee emp)
        {
            int res = _Repository.AddEmployee(emp);
            if (res != 0)
                ViewBag.msg = "Record Inserted..";
            else
                ViewBag.msg = "Record not Inserted..";



            return View();
        }
        public IActionResult EditEmployee(int id)
        {

            var emp = _Repository.GetEmployeeById(id);

            return View(emp);
        }
        [HttpPost]
        public IActionResult EditEmployee(Employee emp)
        {

            _Repository.UpdateEmployee(emp);

            return RedirectToAction("AllEmployess");
        }
        public IActionResult GetEmployeeById(int id)
        {

            var emp = _Repository.GetEmployeeById(id);

            return View(emp);
        }


    }
}
