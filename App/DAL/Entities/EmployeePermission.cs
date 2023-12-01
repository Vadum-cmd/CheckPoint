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

        required public string Title { get; set; }

        required public string Acts { get; set; }

        public IList<Employee>? Employees { get; set; }
    }
}