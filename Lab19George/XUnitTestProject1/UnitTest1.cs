using Lab19George.Models;
using Lab19George.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void CanChangeCity()
        {
            // Arrange
            var c = new Destination { City = "Atlanta" };

            // Act
            c.City = "Tacoma";

            // Assert
            Assert.Equal(c.City, "Tacoma");
        }

        [Fact]
        public void CityIsString()
        {
            // Arrange
            var c = new Destination();

            // Act
            c.City = "Seattle";

            // Assert
            Assert.IsType<string>(c.City);
        }

                [Fact]
        public void HomeIndexResultIsAView()
        {
            // Arrange
            HomeController c = new HomeController();

            // Act
            IActionResult result = c.Index();

            // Assert
            Assert.IsType<ViewResult>(result);
        }
    }
}
