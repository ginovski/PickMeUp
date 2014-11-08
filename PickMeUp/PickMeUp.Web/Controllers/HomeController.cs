namespace PickMeUp.Web.Controllers
{
    using PickMeUp.Models;
    using System.Web.Mvc;

    using PickMeUp.Data.Repositories;

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}