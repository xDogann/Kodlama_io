using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSimulation.Entities
{
    public class ItemSales:Gamer
    {
        public int ItemSalesId { get; set; }
        public string ItemSalesName { get; set; }
        public DateTime ItemSalesTime { get; set; }
    }
}
