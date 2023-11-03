using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class SaleStatistic
    {
        public int Id { get; set; }
        public required int SaleStatisticProductId { get; set; }
        public int? SoldOut { get; set; }
        public DateTime? SaleDate { get; set; }
        public int? Expired { get; set; }

        public required Product Product { get; set; }
    }
}
