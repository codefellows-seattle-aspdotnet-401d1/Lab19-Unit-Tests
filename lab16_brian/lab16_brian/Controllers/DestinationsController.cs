
using lab16_brian.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace lab16_brian.Controllers
{
    public class DestinationsController : Controller
    {
        private readonly IDestinations _destinations;

        public DestinationsController(IDestinations destination)
        {
            _destinations = destination;
        }

        public ViewResult Index()
        {
            return View(_destinations.Destinations);
        }
    }
}
