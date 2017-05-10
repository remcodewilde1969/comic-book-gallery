using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        //ContentResult erft van ActionResult

        public ActionResult Detail()
        {
            if (DateTime.Today.DayOfWeek==DayOfWeek.Thursday)
            {
                return Redirect("http://google.com");
                //return new RedirectResult("http://google.com");
            };

            return Content("Dit is mijn eerste MCV Controller Method");

            //return new ContentResult
            //{
            //    Content= "Dit is mijn eerste MCV Controller Method"
            //};
            // gebruiken maken van een string is niet handig bij een controler
            //return "Dit is mijn eerste MCV Controller Method";
        }
    }
}