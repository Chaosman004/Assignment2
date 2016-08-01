using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
/*
 * Author: Robert Page 200281838
 * Website: http://robcomp2007assignment2.azurewebsites.net/
 * Description: this controller displays the home and contact views
*/
namespace COMP2007_S2016_Lesson10C.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Home/Contact/
        public ActionResult Contact()
        {
            return View();
        }


    }
}