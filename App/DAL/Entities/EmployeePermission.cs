using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class EmployeePermission
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required JSObject Acts { get; set; }

        public required IList<Employee> Employees { get; set; }
    }
}
