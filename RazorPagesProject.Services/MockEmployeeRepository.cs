using System.Collections.Generic;
using RazorPagesProject.Models;

namespace RazorPagesProject.Services
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>
            {
                new Employee
                {
                    Id = 0,
                    Name = "Mary",
                    Email = "mary@example.com", 
                    PhotoPath = "avatarMary.png",
                    Department = Dept.HR
                },
                new Employee
                {
                    Id = 1,
                    Name = "Mark",
                    Email = "mark@example.com",
                    PhotoPath = "avatarMark.png",
                    Department = Dept.IT
                },
                new Employee
                {
                    Id = 2,
                    Name = "Ben",
                    Email = "ben@example.com",
                    PhotoPath = "avatarBen.png",
                    Department = Dept.Payroll
                },
                new Employee
                {
                    Id = 3,
                    Name = "Sara",
                    Email = "sara@example.com",
                    PhotoPath = "avatarSara.png",
                    Department = Dept.HR
                },
                new Employee
                {
                    Id = 4,
                    Name = "John",
                    Email = "john@example.com",
                    Department = Dept.IT
                }
            };
        }
        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeList;
        }
    }
}