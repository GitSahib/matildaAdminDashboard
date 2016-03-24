using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5App.Controllers
{
    [Authorize]
    public class PagesController : Controller
    {
        // GET: Pages
        public ActionResult Widgets()
        {
            return View();
        }
        public ActionResult Calendar()
        {
            return View();
        }
        public ActionResult Chart()
        {
            return View();

        }
        public ActionResult FileManager()
        {
            return View();
        }
        public ActionResult Form()
        {
            return View();
        }
        public ActionResult Gallery()
        {
            return View();
        }
        public ActionResult Icon()
        {
            return View();
        }
        public ActionResult Messages()
        {
            return View();
        }
        public ActionResult Submenu()
        {
            return View();
        }
        public ActionResult Submenu2()
        {
            return View();
        }
        public ActionResult Submenu3()
        {
            return View();
        }
        public ActionResult Table()
        {
            return View();
        }
        public ActionResult Tasks()
        {
            return View();
        }
        public ActionResult Typography()
        {
            return View();
        }
        public ActionResult Ui()
        {
            return View();
        }
        public ActionResult Login() {
            return View();
        }
    }
}