using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class EmployeeSession
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public DateTime Time { get; set; }

        public required Employee Employee { get; set; }
    }
}
