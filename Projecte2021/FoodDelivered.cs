using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecte2021
{
    class FoodDelivered
    {
        public string DeliveredNote { get; set; }
        public string DeliveredDate { get; set; }
        public string HostFullName { get; set; }
        public string TotalPrice { get; set; }
        public List<string> Foods { get; set; }
    }
}
