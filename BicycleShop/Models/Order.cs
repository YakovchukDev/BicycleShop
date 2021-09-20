using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BicycleShop.Models
{
    public class Order
    {
        public int Id { get; set; }
        [Required(ErrorMessage="Invalid information!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Invalid information!")]
        public string Lastname { get; set; }
        [Required(ErrorMessage = "Invalid information!")]
        [EmailAddress]
        public string EmailAddress { get; set; }
        [Required(ErrorMessage = "Invalid information!")]
        [Phone]
        public string ContactPhone { get; set; }
        public int BicycleId { get; set; }
    }
}
