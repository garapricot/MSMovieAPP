using System.Web;
using System.Web.Mvc;

namespace MVCMSMovieapp.Controllers
{
    public class HelloWorldController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Welcome(string name,int numtimes=1)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = numtimes;
            return View();
        }
    }
}