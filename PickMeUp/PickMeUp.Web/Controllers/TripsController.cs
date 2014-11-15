namespace PickMeUp.Web.Controllers
{
    using System.Linq;
    using System.Web.Mvc;

    using AutoMapper;
    using AutoMapper.QueryableExtensions;

    using Microsoft.AspNet.Identity;

    using PickMeUp.Models;
    using PickMeUp.Data.Repositories;
    using PickMeUp.Web.ViewModels;

    public class TripsController : Controller
    {
        private IRepository<Trip> trips;
        private IRepository<City> cities;

        public TripsController(IRepository<Trip> trips, IRepository<City> cities)
        {
            this.trips = trips;
            this.cities = cities;
        }

        public ActionResult Create()
        {
            var cities = this.cities.All().ToList();
            ViewBag.Cities = cities;

            return View();
        }

        [HttpPost]
        public ActionResult Create(CreateTripViewModel trip)
        {
            if (ModelState.IsValid)
            {
                var newTrip = new Trip
                {
                    From = this.cities.GetById(trip.FromId),
                    To = this.cities.GetById(trip.ToId),
                    AdditionalInformation = trip.AdditionalInformation,
                    AvailableSeats = trip.AvailableSeats,
                    Price = trip.Price,
                    DriverId = User.Identity.GetUserId()
                };

                this.trips.Add(newTrip);
                this.trips.SaveChanges();

                return Redirect("/Trips/Details/" + newTrip.Id);
            }

            return View();
        }

        public ActionResult Details(int id)
        {
            var trip = Mapper.Map<Trip, TripViewModel>(this.trips.GetById(id));

            return View(trip);
        }
    }
}