using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BenimHesabim.Models;

namespace BenimHesabim.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        Context context = new Context();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Account()
        {
            Customer c1 = context.Customers.FirstOrDefault();
            List<Log> log = context.Logs.ToList();
            log.Reverse();
            ViewBag.Customer = c1;
            return View(log);
        }

        [HttpGet]
        public IActionResult Deposit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Deposit(Log log)
        {
            Customer c1 = context.Customers.FirstOrDefault();
            c1.Deposit(log.Amount);
            log.Date = DateTime.Now;
            log.Type = "Deposit";
            context.Logs.Add(log);
            context.SaveChanges();
            ViewBag.Customer = c1;
            //return View() 
            return RedirectToAction("Account");
        }
        [HttpGet]
        public IActionResult Withdraw()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Withdraw(Log log)
        {
            Customer c1 = context.Customers.FirstOrDefault();
            var result = c1.Withdraw(log.Amount);
            log.Date = DateTime.Now;
            log.Type = "Withdraw";
            context.Logs.Add(log);
            context.SaveChanges();
            ViewBag.Customer = c1;
            return View();
        }
        [HttpGet]
        public IActionResult Send()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Send(Log log)
        {
            Customer c1 = context.Customers.Find(1);
            Customer c2 = context.Customers.Find(log.Receiver.ID);
            var result = c1.Withdraw(log.Amount);
            if (result)
            {
                log.Date = DateTime.Now;
                log.Type = "Send";
                log.Sender = c1;
                log.Receiver = c2;
                context.Logs.Add(log);
                c2.Deposit(log.Amount);
                context.SaveChanges();
            }
            ViewBag.Customer = c1;
            return View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
