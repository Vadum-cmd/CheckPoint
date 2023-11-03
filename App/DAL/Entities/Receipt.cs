using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Receipt
    {
        public int Id { get; set; }
        public required float TotalPrice { get; set; }
        public required DateTime DateOf { get; set; }

        public required IList<ProductReceipt> ProductReceipts { get; set; }
    }
}
