using Microsoft.EntityFrameworkCore;

namespace CRUD_DI_Demo2_Collection_SQL_MVC_Core.Models
{
    public class EmployDbContext : DbContext
    {
        public EmployDbContext(DbContextOptions<EmployDbContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }

    }
}
