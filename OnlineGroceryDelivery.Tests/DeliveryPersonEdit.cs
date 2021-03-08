using System; 
using Xunit; 
using Xunit.Abstractions; 
using OnlineGroceryDelivery.Models;

namespace OnlineGroceryDelivery.Tests
{
    public class DeliveryPersonTest{

        [Fact]
        public void CanEditDeliveryPersonName()
        {
            //Arrange
            var t = new DeliveryPerson { DeliveryPersonId = Int32.Parse("123"), Name = "Jake" };

            //Act
            t.Name = "Steve"; 

            //Assert
            Assert.Equal("Steve", t.Name);

        }
    }
}