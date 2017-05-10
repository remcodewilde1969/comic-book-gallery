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
            return View();
        }
    }
}