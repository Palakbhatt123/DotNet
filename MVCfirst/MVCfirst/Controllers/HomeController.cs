using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCfirst.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(int Emp_Id,string Emp_Name,String Emp_Add)

        {
            ViewBag.SucessMessage = "Employee Info save"+ Emp_Id;    
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
       
        public ActionResult show()
        {

            
            return View();

        }
    }
}