using BicycleShop.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BicycleShop.Controllers
{
    public class AdminController : Controller
    {
        BicycleContext context;
        public AdminController(BicycleContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IActionResult Index(int? page)
        {
            ViewBag.Count = context.Bicycles.ToList().Count;
            ViewBag.PageSize = 15;
            if (page == null)
            {
                return View(context.Bicycles
                    .Skip(0)
                    .Take((int)ViewBag.PageSize)
                    .ToList());
            }
            else
            {
                return View(context.Bicycles
                    .Skip((int)((page - 1) * (int)ViewBag.PageSize))
                    .Take((int)ViewBag.PageSize)
                    .ToList());
            }
            
        }

        //Add
        [HttpGet]
        public IActionResult Add()
        {
            return View(new Bicycle());
        }
        [HttpPost]
        public IActionResult Add(Bicycle bicycle)
        {
            if (bicycle.Price < 1)
            {
                ModelState.AddModelError("Price", "Product price cannot be 0 or less than 0.");
            }
            if (bicycle.Wheels < 1)
            {
                ModelState.AddModelError("Wheels", "Wheels diameter cannot be 0 or less than 0.");
            }
            if (bicycle.Frame < 1)
            {
                ModelState.AddModelError("Frame", "Frame diameter cannot be 0 or less than 0.");
            }
            if (bicycle.YearOfIssue < 2000)
            {
                ModelState.AddModelError("YearOfIssue", "Too old product.");
            }

            if (ModelState.IsValid)
            {
                context.Bicycles.Add(bicycle);
                context.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                return View(bicycle);
            }
        }

        //Edit
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View(context.Bicycles.Find(id));
            }
        }
        [HttpPost]
        public IActionResult Edit(Bicycle bicycle)
        {
            if(bicycle.Price < 1)
            {
                ModelState.AddModelError("Price", "Product price cannot be 0 or less than 0.");
            }
            if (bicycle.Wheels < 1)
            {
                ModelState.AddModelError("Wheels", "Wheels diameter cannot be 0 or less than 0.");
            }
            if (bicycle.Frame < 1)
            {
                ModelState.AddModelError("Frame", "Frame diameter cannot be 0 or less than 0.");
            }
            if (bicycle.YearOfIssue < 2000)
            {
                ModelState.AddModelError("YearOfIssue", "Too old product.");
            }

            if (ModelState.IsValid)
            {
                var bicycleEdit = context.Bicycles.Find(bicycle.Id);
                bicycleEdit.Title = bicycle.Title;
                bicycleEdit.Brand = bicycle.Brand;
                bicycleEdit.Price = bicycle.Price;
                bicycleEdit.Class = bicycle.Class;
                bicycleEdit.Wheels = bicycle.Wheels;
                bicycleEdit.Frame = bicycle.Frame;
                bicycleEdit.Color = bicycle.Color;
                bicycleEdit.YearOfIssue = bicycle.YearOfIssue;
                bicycleEdit.Saddle = bicycle.Saddle;
                context.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                return View(bicycle);
            }
        }

        //Delete
        [HttpPost]
        public IActionResult Delete(int id)
        {
            context.Bicycles.Remove(context.Bicycles.Find(id));
            context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
