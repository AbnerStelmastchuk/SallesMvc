using SallesMvc.Models;
using System.Collections.Generic;
using System.Linq;


namespace SallesMvc.Services
{
    public class DepartmentService
    {
        private readonly SallesMvcContext _context;

        public DepartmentService(SallesMvcContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
