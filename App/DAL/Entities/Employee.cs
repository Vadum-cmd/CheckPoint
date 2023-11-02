using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace DAL.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Surname { get; set; }
        public required string Position { get; set; }
        public required string Login { get; set; }
        public required string Password { get; set; }

        public int EmployeePermissionId { get; set; }
        public required EmployeePermission EmployeePermission { get; set; }

        public IList<EmployeeSession>? EmployeeSessions { get; set; }
    }
}
