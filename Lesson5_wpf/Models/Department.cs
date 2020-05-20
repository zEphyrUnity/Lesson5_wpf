using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5_wpf.Models
{
    class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Employee> Employee { get; set; } = new List<Employee>();
    }
}
