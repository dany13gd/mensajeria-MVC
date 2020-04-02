
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MensajeriaMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
         
        public ActionResult MainActivity()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateEditFormActivity()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ContactDetailActivity()
        {            
            return View(); 
        }

        [HttpPost]
        public ActionResult ListActivity()
        {

            return View();
        }

    }
}