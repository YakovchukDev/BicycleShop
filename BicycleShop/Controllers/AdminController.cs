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
            var pageSize = 10;
            if (page == null)
            {
                return View(context.Bicycles
                    .Skip(0)
                    .Take(pageSize)
                    .ToList());
            }
            else
            {
                return View(context.Bicycles
                    .Skip((int)((page - 1) * pageSize))
                    .Take(pageSize)
                    .ToList());
            }
            
        }

        //Add
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Bicycle bicycle)
        {
            context.Bicycles.Add(bicycle);
            context.SaveChanges();

            return RedirectToAction("Index");
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
