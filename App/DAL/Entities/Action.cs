using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Action
    {
        public int Id { get; set; }
        public required int ActionProductId { get; set; }
        public required float Discount { get; set; }
        public required DateTime DateFrom { get; set; }
        public required DateTime DateTo { get; set; }
        public int? Amount { get; set; }

        public required Product Product { get; set; }
    }
}
