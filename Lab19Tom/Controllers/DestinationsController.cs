using Lab19Tom.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab19Tom.Controllers
{
    public class DestinationsController : Controller
    {
        //implementing dependency injection with interface
        private IDestinationsRepository _repository;

        public DestinationsController(IDestinationsRepository repo)
        {
            _repository = repo;
        }

        public ViewResult Index()
        {
            return View(_repository.Destinations);
        }
    }
}
