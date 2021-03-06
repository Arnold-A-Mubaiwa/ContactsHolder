﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web;
// using ContactsHolder.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace ContactsHolder.Controllers {
    public class HomeController : Controller {
        private readonly ILogger<HomeController> _logger;
        private readonly ContactsHolder.Models.ContactContext _context;
        public HomeController (ILogger<HomeController> logger,ContactsHolder.Models.ContactContext context) {
            _logger = logger;
            _context = context;
        }
        // public IActionResult Index () {
        //     return View ();
        // }
        public async Task<IActionResult> Index (string searchString = "Yes") {
            var contactNo = from m in _context.Contact
            select m;

            if (!String.IsNullOrEmpty (searchString)) {                
                contactNo = contactNo.Where (s => s.Importance.Contains (searchString));
            }

            return View (await contactNo.ToListAsync());
        }

        public IActionResult Privacy () {
            return View ();
        }
        public IActionResult AboutUs () {
            return View ();
        }

        [HttpPost]
        public ViewResult AboutUs (ContactsHolder.Models.Mail _objMail) {
            if (ModelState.IsValid) {
                MailMessage mail = new MailMessage ();
                mail.To.Add ("durnoldsinstitute@gmail.com");
                mail.From = new MailAddress ("durnoldsinstitute@gmail.com");
                mail.Subject = "Feedback";
                string Body = _objMail.Body;
                mail.Body = Body;
                mail.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient ();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential ("durnoldsinstitute@gmail.com", "@arnold.1"); // Enter seders User name and password  
                smtp.EnableSsl = true;
                smtp.Send (mail);
                return View ("Index", _objMail);
            } else {
                return View ();
            }
        }
        

        [ResponseCache (Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error () {
            return View (new ContactsHolder.Models.ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}