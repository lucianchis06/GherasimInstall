using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CMS.Web.Controllers
{
    public class EditorController : Controller
    {
        // GET: Editor
        public ActionResult Html()
        {
            return View();
        }

        public ActionResult Word()
        {
            return View();
        }

        public ActionResult Excel()
        {
            return View();
        }

        public ActionResult Pdf()
        {
            return View();
        }
    }
}