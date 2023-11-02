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
        public int ProductId { get; set; }
        public float Discount { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public int Amount { get; set; }

        public required Product Product { get; set; }
    }
}
