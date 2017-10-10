using Lab19George.Models;
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
    }
}
