using Lesson5_wpf.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5_wpf.Services
{
    class EmployeeManager
    {
        public List<EmployeeDeparment> Departments { get; }
        public EmployeeManager()
        {
            var employee_id = 1;
            Departments = Enumerable
                .Range(1, 5)
                .Select(i => new EmployeeDeparment()
                {
                    Id = i,
                    Name = $"Department {i}",
                    Employee = Enumerable
                    .Range(1, 10)
                    .Select(j => new Employee
                    {
                        Id = employee_id,
                        Name = $"Name {employee_id}",
                        Surname = $"Surname {employee_id}",
                        Patronymic = $"Patronymic {employee_id++}"
                    }).ToList()
                })
                .ToList();

            foreach (var department in Departments)
                foreach (var employee in department.Employee)
                    employee.Department = department;
        }
    }
}