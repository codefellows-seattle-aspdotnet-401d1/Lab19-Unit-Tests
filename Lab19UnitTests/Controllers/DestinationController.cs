using Lab19UnitTests.Models.Repos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab19UnitTests.Controllers
{
    public class DestinationController : Controller
    {
        public IDestinationRepository _repository;

        public DestinationController()
        {
        }

        public DestinationController(IDestinationRepository repo)
        {
            _repository = repo;
        }

        public ViewResult Index()
        {
            return View(_repository.Destination);
        }
    }
}
