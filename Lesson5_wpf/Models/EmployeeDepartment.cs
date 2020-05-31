using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Lesson5_wpf.Models
{
    internal class EmployeeDeparment
    {
        public int Id { get; set; }

        public string Name { get; set; }

        internal List<Employee> _Employee { get; set; } = new List<Employee>();
    }
}
