using Lab19George.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab19George.Controllers
{
    public class DestinationController : Controller
    {
        private readonly IDestinationRepository _destination;

        public DestinationController(IDestinationRepository destin)
        {
            _destination = destin;
        }

        public ViewResult Index()
        {
            return View(_destination.Destinations);
        }
    }
}
