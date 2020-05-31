using Lesson5_wpf.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.ComponentModel;

namespace Lesson5_wpf.Services
{
    class EmployeeManager
    {
        public static List<EmployeeDeparment> Departments { get; } = new List<EmployeeDeparment>();

        public static void LoadFromFile()
        {
            int _employeeId = 0;
            int _departmentId = 0;
            const int _departmentMaxEpmloyees = 10;
            EmployeeDeparment deparment = new EmployeeDeparment();

            using (var file_reader = File.OpenText("Employee.txt"))
                while (!file_reader.EndOfStream)
                {
                    var str = file_reader.ReadLine();

                    if (string.IsNullOrWhiteSpace(str)) return;

                    var components = str.Split(';');

                    var Person = new Employee
                    {
                        Id = _employeeId++,
                        Surname = components[0],
                        Name = components[1],
                        Patronymic = components[2],                  
                    };
                    
                    deparment._Employee.Add(Person);
                    
                    if(_employeeId >= _departmentMaxEpmloyees)
                    {
                        deparment.Name = _departmentId++.ToString();
                        Departments.Add(deparment);
                        _employeeId = 0;
                        deparment = new EmployeeDeparment();
                    }
                }
        }

        public EmployeeManager()
        {

            //var employee_id = 1;
            //Departments = Enumerable
            //    .Range(1, 5)
            //    .Select(i => new EmployeeDeparment()
            //    {
            //        Id = i,
            //        Name = $"Department {i}",
            //        _Employee = Enumerable
            //        .Range(1, 10)
            //        .Select(j => new Employee
            //        {
            //            Id = employee_id,
            //            Name = $"Name {employee_id}",
            //            Surname = $"Surname {employee_id}",
            //            Patronymic = $"Patronymic {employee_id++}"
            //        }).ToList()
            //    })
            //    .ToList();

            //foreach (var department in Departments)
            //    foreach (var employee in department._Employee)
            //        employee.Department = department; 
        }
    }
}