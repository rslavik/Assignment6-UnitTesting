using System; 
using Xunit; 
using Xunit.Abstractions; 
using OnlineGroceryDelivery.Models;

namespace OnlineGroceryDelivery.Tests
{
    public class EditDataTest{

        [Fact]
        public void CanEditCustomerEmail()
        {
            //Arrange
            var t = new Customer { CustomerId = Int32.Parse("123"), LoginId = "jwendt", Password = "123pw", Name = "Jake", Address = "123 Park Dr", Phone = "817-123-4565", Email = "jwendt@yahoo.com" };

            //Act
            t.Email = "jakewendt@yahoo.com"; 

            //Assert
            Assert.Equal("jakewendt@yahoo.com", t.Email);

        }

        [Fact]
        public void CanEditOderDeliveryAddress()
        {
            //Arrange
            var x = new Order {OrderId = Int32.Parse("12"), CustomerId = Int32.Parse("123"), Customer = "jwendt", StatusId = "123jw", OrderDate = DateTime.Parse("03/01/2021"), DeliveryDate = DateTime.Parse("03/07/2021"), DeliveryAddress = "123 Park Dr", OrderStatusId = Int32.Parse("156"), OrderStatus = "complete", DeliveryId = Int32.Parse("1234") };
            
            //Act
            x.DeliveryAddress = "124 Park Dr"; 

            //Assert
            Assert.Equal("124 Park Dr", x.DeliveryAddress);

        }
        }

    }
