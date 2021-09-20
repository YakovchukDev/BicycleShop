using BicycleShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace BicycleShop.Controllers
{
    public class HomeController : Controller
    {
        BicycleContext context;
        public HomeController(BicycleContext context)
        {
            this.context = context;
            ViewBag.IsOrderSuccess = "No";
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

        [HttpGet]
        public IActionResult Buy(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Id = id;
                return View();
            }
        }
        [HttpPost]
        public IActionResult Buy(Order order)
        {
            try
            {
                using (StreamReader sr = new StreamReader("EmailAdress.txt", System.Text.Encoding.Default))
                {
                    string email = sr.ReadLine();
                    string password = sr.ReadLine();

                    MailAddress from = new MailAddress(email, "Bicycle shop");
                    MailAddress to = new MailAddress(order.EmailAddress);
                    MailMessage m = new MailMessage(from, to);
                    m.Subject = "Order";
                    m.Body = "Hello, you have just ordered a bike. Please be advised that we have already started to arrange it.";

                    SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                    smtp.Credentials = new NetworkCredential(email, password);
                    smtp.EnableSsl = true;
                    smtp.Send(m);
                }
            }
            catch { }

            context.Orders.Add(order);
            context.SaveChanges();

            ViewBag.IsOrderSuccess = "Yes";
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
