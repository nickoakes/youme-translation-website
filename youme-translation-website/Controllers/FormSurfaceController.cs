using youme_website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace youme_website.Controllers
{
    public class FormSurfaceController : SurfaceController
    {
        [HttpPost]
        public ActionResult Submit(FormViewModel model)
        {
            if (!ModelState.IsValid)
                return CurrentUmbracoPage();

            return RedirectToCurrentUmbracoPage();
        }
    }
}