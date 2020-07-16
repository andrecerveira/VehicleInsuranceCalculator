using System.Web.Mvc;

namespace VehicleInsuranceCalculator.MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult SearchInsurance()
        {
            ViewBag.Title = "Search Insurance Teste";

            return View();
        }
    }
}
