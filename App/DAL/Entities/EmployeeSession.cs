namespace DAL.Entities
{
    using System;

    public class EmployeeSession
    {
        public int Id { get; set; }

        required public int EmployeeId { get; set; }

        required public DateTime Time { get; set; }

        required public Employee Employee { get; set; }
    }
}