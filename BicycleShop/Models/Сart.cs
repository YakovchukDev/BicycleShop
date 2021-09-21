using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace BicycleShop.Models
{
    public class Cart
    {
        private List<Product> productCollection = new List<Product>();
        public void Add(Bicycle bicycle, int quantity = 1)
        {
            Product product = productCollection
                .FirstOrDefault(x => x.Bicycle.Id == bicycle.Id);
            if(product == null)
            {
                productCollection
                    .Add(new Product
                    {
                        Bicycle = bicycle,
                        Quantity = quantity
                    });
            }
            else
            {
                product.Quantity += quantity;
            }
        }
        public void Change(Bicycle bicycle, int quantity = 1)
        {
            Product product = productCollection
                .FirstOrDefault(x => x.Bicycle.Id == bicycle.Id);
            if (product == null)
            {
                productCollection
                    .Add(new Product
                    {
                        Bicycle = bicycle,
                        Quantity = quantity
                    });
            }
            else
            {
                product.Quantity = quantity;
            }
        }
        public void Remove(Bicycle bicycle)
        {
            Product product = productCollection
                .FirstOrDefault(x => x.Bicycle.Id == bicycle.Id);
            productCollection.Remove(product);
        }
        public void Clear()
        {
            productCollection.Clear();
        }
        public IEnumerable<Product> Products()
        {
            return productCollection;
        }
    }
    public class Product
    {
        [Required(ErrorMessage = "Invalid information!")]
        public Bicycle Bicycle { get; set; }
        [Required(ErrorMessage = "Invalid information!")]
        public int Quantity { get; set; }
    }
}
