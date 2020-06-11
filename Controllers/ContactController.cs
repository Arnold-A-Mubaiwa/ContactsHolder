using System;
using Microsoft.AspNetCore.Mvc;
using ContactsHolder.Models;
using Microsoft.Extensions.Logging;
using System.Text.Encodings.Web;

namespace ContactsHolder.Controllers{
    public class ContactController : Controller{
        public IActionResult Index(){
          return  View();
        }
    }
}