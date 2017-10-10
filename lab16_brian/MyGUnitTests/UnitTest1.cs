using lab16_brian.Models;
using System;
using Xunit;

namespace MyGUnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            var d = new Destination {Dest = "Foo"};

            //Act
            d.Dest = "Bar";

            //Assert
            Assert.Equal("Not", d.Dest);
        }
    }
}
