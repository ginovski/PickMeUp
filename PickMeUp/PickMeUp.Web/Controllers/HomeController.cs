namespace PickMeUp.Web.Controllers
{
    using System.Web.Mvc;

    using AutoMapper.QueryableExtensions;

    using PickMeUp.Models;
    using PickMeUp.Data.Repositories;
    using PickMeUp.Web.ViewModels;

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}