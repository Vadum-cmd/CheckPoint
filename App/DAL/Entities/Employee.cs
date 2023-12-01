namespace DAL.Entities
{
    using System.Collections.Generic;

    public class Employee
    {
        public int Id { get; set; }

        required public string Name { get; set; }

        required public string Surname { get; set; }

        required public string Position { get; set; }

        required public string Login { get; set; }

        required public string Password { get; set; }

        required public int EmployeePermissionId { get; set; }

        required public EmployeePermission EmployeePermission { get; set; }

        public IList<EmployeeSession>? EmployeeSessions { get; set; }
    }
}