using Lab19erik.Model;
using System;
using Xunit;

namespace MyTest.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {   
            //Arrange
            var l = new Location { Name="seattle" };

            //Act 
            l.Name = "Kent";

            //Assert
            Assert.Equal("Kent", l.Name);
        }

        [Fact]
        public void Test2()
        {   
            //Arrange
            var l = new Location();

            //Act 
            l.Name = "Renton";

            //Assert
            Assert.NotNull(l); 

        }
    }
}
