using Lab19erik.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab19erik.Controllers
{
    public class LocationsController : Controller
    {
        private readonly ILocationRepo _repository;

        public LocationsController(ILocationRepo repo)
        {
            _repository = repo;
        }

        public ViewResult Index()
        {
            return View(_repository.Location);
        }
    }
}
