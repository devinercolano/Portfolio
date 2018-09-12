using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using portfolio.Models;

namespace portfolio.Controllers
{
    public class ContactController : Controller
    {
        [HttpGet]
        [Route("contact")]
        public IActionResult Contact()
        {
            return View("Contact");
        }

        [HttpPost]
        [Route("Submit")]
        public IActionResult Submit(Visitor visitor)
        {
            if(ModelState.IsValid) {
                string name = visitor.name;
                string email = visitor.email;
                string messageText = visitor.messageText;
                return RedirectToAction("Contact");

            } else {
                return View("Contact");
            }
        }
    }
}