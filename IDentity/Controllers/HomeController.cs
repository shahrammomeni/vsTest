using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDentity.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            
            return View();    
        }
        
    
    }
}

public enum HeaderViewRenderMode { Full, Menu, Title }