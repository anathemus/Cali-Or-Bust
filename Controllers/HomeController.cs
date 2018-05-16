using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OrBust.Models;
using OrBust.Services;

namespace OrBust.Controllers
{
    [RequireHttps]
    [Authorize]
    public class HomeController : Controller
    {

        public HomeController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public async Task SendEmail(string message)
        {
            if (message != null)
            {
                var smtpClient = new SmtpClient
                {
                    Host = "smtp.gmail.com", // set your SMTP server name here
                    Port = 587, // Port 
                    EnableSsl = true,
                    Credentials = new NetworkCredential("benjamin.burgess.azure@gmail.com", "Tj09212014")
                };

                using (var mailMessage = new MailMessage("benjamin.burgess.azure@gmail.com", "benjamin.a.burgess@outlook.com")
                {
                    Subject = "Or Bust - Results",
                    Body = message,
                    IsBodyHtml = true
                })

                {
                    await smtpClient.SendMailAsync(mailMessage);
                }
            }

            // return RedirectToAction("Index");
        }
    }
}
