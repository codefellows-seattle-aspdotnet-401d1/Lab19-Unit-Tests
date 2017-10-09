using Lab19Tom.Models;
using System;
using Xunit;

namespace MyTests.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void CanChangeDestination()
        {
            // Arrange
            var d = new Destinations { Destination = "London" };

            //Act
            d.Destination = "Sydney";

            //Assert
            Assert.Equal("Sydney", d.Destination);

        }
    }
}
