using System.Web.Http.Cors;
using System.Web.Mvc;

/*****************************************************
* Project Name: DeCKR                                *
* Date: 07/01/2019                                   *
* Course: CSC 687 - Computer Science Project II      *
* Instructor: Mudasser Wyne                          *
******************************************************/

namespace DeCKR_WebAPI.Controllers
{
    /// <summary>
    /// Home Controller class
    /// </summary>
   // [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class HomeController : Controller
    {        
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            //Main page View
            return View();
        }
    }
}
