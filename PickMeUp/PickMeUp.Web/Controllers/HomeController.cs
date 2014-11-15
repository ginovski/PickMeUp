namespace PickMeUp.Web.Controllers
{
    using System.Linq;
    using System.Web.Mvc;

    using AutoMapper.QueryableExtensions;

    using PickMeUp.Models;
    using PickMeUp.Data.Repositories;
    using PickMeUp.Web.ViewModels;

    public class HomeController : Controller
    {
        private IRepository<Trip> trips;

        public HomeController(IRepository<Trip> trips)
        {
            this.trips = trips;
        }

        public ActionResult Index()
        {
            return View(this.trips.All());
        }
    }
}