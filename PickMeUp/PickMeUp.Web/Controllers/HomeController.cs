namespace PickMeUp.Web.Controllers
{
    using PickMeUp.Models;
    using System.Web.Mvc;

    using PickMeUp.Data.Repositories;

    public class HomeController : Controller
    {
        private IRepository<City> cities;

        public HomeController(IRepository<City> cities)
        {
            this.cities = cities;
        }

        public ActionResult Index()
        {
            var cities = this.cities.All();

            return View(cities);
        }
    }
}