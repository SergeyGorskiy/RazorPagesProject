using System.Collections.Generic;
using RazorPagesProject.Models;

namespace RazorPagesProject.Services
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAllEmployees();
    }
}