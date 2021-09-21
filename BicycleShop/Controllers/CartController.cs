using BicycleShop.Exstension;
using BicycleShop.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BicycleShop.Controllers
{
    public class CartController : Controller
    {
        BicycleContext context;
        public CartController(BicycleContext context)
        {
            this.context = context;
        }

        private Cart GetCart()
        {
            Cart cart = HttpContext.Session.GetObjectFromJson<Cart>("Cart");

            if(cart == null)
            {
                cart = new Cart();
                HttpContext.Session.SetObjectAsJson("Cart", cart);
            }

            return cart;
        }

        public IActionResult Index()
        {
            Cart cart = GetCart();
            return View(cart.Products());
        }

        [HttpGet]
        public IActionResult AddToCart(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View(new Product
                {
                    Bicycle = context.Bicycles.Find(id),
                    Quantity = 0
                });
            }
        }
        [HttpPost]
        public IActionResult AddToCart(int id, int quantity)
        {
            if (quantity < 1)
            {
                ModelState.AddModelError("Price", "Product price cannot be 0 or less than 0.");
            }
            
            if(ModelState.IsValid)
            {
                Bicycle bicycle = context.Bicycles.First(x => x.Id == id);

                Cart cart = GetCart();
                cart.Add(bicycle, quantity);
                HttpContext.Session.SetObjectAsJson("Cart", cart);

                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View(new Product
                {
                    Bicycle = context.Bicycles.Find(id),
                    Quantity = quantity
                });
            }
        }

        [HttpPost]
        public IActionResult RemoteFromCart(int id)
        {
            Bicycle bicycle = context.Bicycles.First(x => x.Id == id);

            Cart cart = GetCart();
            cart.Remove(bicycle);
            HttpContext.Session.SetObjectAsJson("Cart", cart);

            return RedirectToAction("Index", "Cart");
        }

        [HttpPost]
        public IActionResult ChangeCart(int id, int quantity)
        {
            if (quantity < 1)
            {
                ModelState.AddModelError("Price", "Product price cannot be 0 or less than 0.");
            }

            if (ModelState.IsValid)
            {
                Bicycle bicycle = context.Bicycles.First(x => x.Id == id);

                Cart cart = GetCart();
                cart.Change(bicycle, quantity);
                HttpContext.Session.SetObjectAsJson("Cart", cart);

                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View(new Product
                {
                    Bicycle = context.Bicycles.Find(id),
                    Quantity = quantity
                });
            }
        }
    }
}
