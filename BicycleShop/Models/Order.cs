using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BicycleShop.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string EmailAddress { get; set; }
        public string ContactPhone { get; set; }
        public int BicycleId { get; set; }
    }
}
