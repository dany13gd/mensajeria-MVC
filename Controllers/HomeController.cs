
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

    
        public ActionResult CreateEditFormActivity()
        {
            return View();
        }


        public ActionResult ContactDetailActivity()
        {            
            return View(); 
        }


        public ActionResult ListActivity()
        {

            return View();
        }

    }
}