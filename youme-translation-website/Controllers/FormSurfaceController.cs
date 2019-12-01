using youme_website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;
using System.Net.Mail;

namespace youme_website.Controllers
{
    public class FormSurfaceController : SurfaceController
    {
        public ActionResult ContactForm()
        {
            return PartialView("ContactForm", new FormViewModel());
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Submit(FormViewModel model)
        {
            if (!ModelState.IsValid)
                return CurrentUmbracoPage();

            SendMessage(model);
            TempData["SuccessResult"] = true;
            return RedirectToCurrentUmbracoPage();              
        }

        private void SendMessage(FormViewModel model)
        {
            MailMessage message = new MailMessage(model.Email, "nickoakes1@googlemail.com");
            message.Subject = model.Subject;
            message.Body = model.Message;
            SmtpClient client = new SmtpClient("127.0.0.1", 25);
            client.Send(message);
        }
    }
}