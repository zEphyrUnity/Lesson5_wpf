﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5_wpf.Models
{
    internal class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }
        
        public string Surname { get; set; }
        
        public string Patronymic { get; set; }
        
        public EmployeeDeparment Department { get; set; }
        
    }
}
