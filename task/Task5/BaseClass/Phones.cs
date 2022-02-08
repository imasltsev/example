using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5.BaseClasses
{
    public class Phone
    {
        public string Model { get; set; }
        public string OperationSystemType { get; set; }
        public string MarketLaunchDate { get; set; }
        public int Price { get; set; }
        public bool IsAvailable { get; set; }
        public int ShopId { get; set; }
    }
}
