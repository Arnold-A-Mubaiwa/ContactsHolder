using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ContactsHolder.Models;
using System.Net.Mail;  
using System.Web;  
namespace ContactsHolder.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult AboutUs(){
            return View();
        }
        [HttpPost]
        public ViewResult AboutUs(ContactsHolder.Models.Mail _objMail){
            if (ModelState.IsValid) {  
                MailMessage mail = new MailMessage();  
                mail.To.Add(_objMail.To);  
                mail.From = new MailAddress(_objMail.From);  
                mail.Subject = _objMail.Subject;  
                string Body = _objMail.Body;  
                mail.Body = Body;  
                mail.IsBodyHtml = true;  
                SmtpClient smtp = new SmtpClient();  
                smtp.Host = "smtp.gmail.com";  
                smtp.Port = 587;  
                smtp.UseDefaultCredentials = false;  
                smtp.Credentials = new System.Net.NetworkCredential("durnoldsinstitute@gmail.com", "@arnold.1"); // Enter seders User name and password  
                smtp.EnableSsl = true;  
                smtp.Send(mail);  
                return View("Index", _objMail);  
            } else {  
                return View();  
            }  
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        
    }
}
