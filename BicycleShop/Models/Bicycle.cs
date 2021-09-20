using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace BicycleShop.Models
{
    public class Bicycle
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Invalid information!")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Invalid information!")]
        public string Brand { get; set; }
        [Required(ErrorMessage = "Invalid information!")]
        public float Price { get; set; }
        [Required(ErrorMessage = "Invalid information!")]
        public string Class { get; set; }
        [Required(ErrorMessage = "Invalid information!")]
        public float Wheels { get; set; }
        [Required(ErrorMessage = "Invalid information!")]
        public float Frame { get; set; }
        [Required(ErrorMessage = "Invalid information!")]
        public string Color { get; set; }
        [Required(ErrorMessage = "Invalid information!")]
        public int YearOfIssue { get; set; }
        [Required(ErrorMessage = "Invalid information!")]
        public string Saddle { get; set; }
    }
}
