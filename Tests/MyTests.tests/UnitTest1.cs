using Lab19UnitTests.Controllers;
using Lab19UnitTests.Models;
using Lab19UnitTests.Models.Repos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Xunit;

namespace MyTests.tests
{
    public class UnitTest1
    {
        [Fact]
        public void CanChangeLocationName()
        {
            //Arrange
            var L = new Destination { LocationName = "A Place" };

            //Act
            L.LocationName = "A Different Place";

            //Assert
            Assert.Equal("A Different Place", L.LocationName);

        }

        [Fact]
        public void CanManipulateList()
        {
            //Arrange
            IEnumerable<Destination> Dest = new List<Destination>
        {
            new Destination {LocationName = "The Grand Tour", Attractions = "Jupiter, Saturn, Uranus, and Neptune", Description = "A 3 month shipboard cruise to the outer giants of our solar system. Food and Lodging included.", Distance = "30.1 AU", PosterPath = "https://www.jpl.nasa.gov/visions-of-the-future/images/grand_tour.jpg" },
            new Destination {LocationName = "Mars", Attractions = "Historical Sites, Shopping, Landscapes, Architecture", Description = "Visit the 1st wonder of our new World, Red City, and marvel at what a united humanity can achieve.", Distance = "1.524 AU", PosterPath = "https://www.jpl.nasa.gov/visions-of-the-future/images/mars.jpg" },
            new Destination {LocationName = "Venus", Attractions = "Cloud 9 Observatory", Description = "Our mini city in the clouds, spend a romantic evening watching Mercury transit the sun.", Distance = "0.723 AU", PosterPath = "https://www.jpl.nasa.gov/visions-of-the-future/images/venus.jpg" },
            new Destination {LocationName = "Ceres", Attractions = "Hiking, Astronomy, EVA Tours, Fine Dining", Description = "Low gravity hiking, with spectacular views of the surrounding asteroid belt.", Distance = "2.77 AU", PosterPath = "https://www.jpl.nasa.gov/visions-of-the-future/images/ceres.jpg" },
            new Destination {LocationName = "Europa", Attractions = "Deep Sea Diving, Low Gravity Ice Sports, Marine Life Exhibits", Description = "Discover the mysterious denizens of Europas vast ocean, right from the comfort of your room, at the Europa Marine Life Resort.", Distance = "5.2 AU", PosterPath = "https://www.jpl.nasa.gov/visions-of-the-future/images/europa.jpg" }
        };

            //Act
            foreach (var D in Dest)
            {
                D.Description = "This is where a description goes, Holmes.";
            }

            //Assert
            foreach (var D in Dest)
            {
                Assert.Contains("This is where a description goes, Holmes.", D.Description);
            }

        }



        [Fact]
        public void TestRepositoryController()
        {
            //Arrange
            var TestController = new DestinationController();
            TestController._repository = new TestRepository();

            // Act
            var model = (TestController.Index() as ViewResult)?.ViewData.Model
                as IEnumerable<Destination>;

            // Assert
            Assert.Equal(TestController._repository.Destination, model,
                    Comparer.Get<Destination>((D1, D2) => D1.LocationName == D2.LocationName
                    && D1.Distance == D2.Distance));
        }


        public class TestRepository : IDestinationRepository
        {
            public IEnumerable<Destination> Destination => new List<Destination>
        {
            new Destination {LocationName = "The Grand Tour", Attractions = "Jupiter, Saturn, Uranus, and Neptune", Description = "A 3 month shipboard cruise to the outer giants of our solar system. Food and Lodging included.", Distance = "30.1 AU", PosterPath = "https://www.jpl.nasa.gov/visions-of-the-future/images/grand_tour.jpg" },
            new Destination {LocationName = "Mars", Attractions = "Historical Sites, Shopping, Landscapes, Architecture", Description = "Visit the 1st wonder of our new World, Red City, and marvel at what a united humanity can achieve.", Distance = "1.524 AU", PosterPath = "https://www.jpl.nasa.gov/visions-of-the-future/images/mars.jpg" },
            new Destination {LocationName = "Venus", Attractions = "Cloud 9 Observatory", Description = "Our mini city in the clouds, spend a romantic evening watching Mercury transit the sun.", Distance = "0.723 AU", PosterPath = "https://www.jpl.nasa.gov/visions-of-the-future/images/venus.jpg" },
            new Destination {LocationName = "Ceres", Attractions = "Hiking, Astronomy, EVA Tours, Fine Dining", Description = "Low gravity hiking, with spectacular views of the surrounding asteroid belt.", Distance = "2.77 AU", PosterPath = "https://www.jpl.nasa.gov/visions-of-the-future/images/ceres.jpg" },
            new Destination {LocationName = "Europa", Attractions = "Deep Sea Diving, Low Gravity Ice Sports, Marine Life Exhibits", Description = "Discover the mysterious denizens of Europas vast ocean, right from the comfort of your room, at the Europa Marine Life Resort.", Distance = "5.2 AU", PosterPath = "https://www.jpl.nasa.gov/visions-of-the-future/images/europa.jpg" }
        };

        }
    }
}
