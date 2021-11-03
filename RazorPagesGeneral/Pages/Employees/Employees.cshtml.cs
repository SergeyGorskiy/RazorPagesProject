using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesProject.Models;
using RazorPagesProject.Services;

namespace RazorPagesGeneral.Pages.Employees
{
    public class EmployeesModel : PageModel
    {
        private readonly IEmployeeRepository _db;

        public IEnumerable<Employee> Employees { get; set; }

        public EmployeesModel(IEmployeeRepository db)
        {
            _db = db;
        }

        public void OnGet()
        {
            Employees = _db.GetAllEmployees();
        }
    }
}
