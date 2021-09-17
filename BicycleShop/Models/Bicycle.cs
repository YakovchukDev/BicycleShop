using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BicycleShop.Models
{
    public class Bicycle
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Brand { get; set; }
        public float Price { get; set; }
        public string Class { get; set; }
        public float Wheels { get; set; }
        public float Frame { get; set; }
        public string Color { get; set; }
        public int YearOfIssue { get; set; }
        public string Saddle { get; set; }
    }
}
