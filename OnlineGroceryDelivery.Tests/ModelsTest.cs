using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Xunit;
using Xunit.Abstractions;
using OnlineGroceryDelivery.Models;

namespace OnlineGroceryDelivery.Tests
{
    public class ModelsTest
    {

        //https://xunit.net/docs/capturing-output
        private readonly ITestOutputHelper outputHelper;

        public DriverPageTests(ITestOutputHelper outputHelper) {
            this.outputHelper = outputHelper;
        }
        
        [Fact]
        public async Task OnPostAddCustomerAsync_ReturnsARedirectToPageResult()
        {
            // Arrange
            var optionsBuilder = new DbContextOptionsBuilder<OnlineGroceryDeliveryContext>()
                .UseInMemoryDatabase("InMemoryDb");
            var OnlineGroceryDeliveryContext = new Mock<OnlineGroceryDeliveryContext>(optionsBuilder.Options) {CallBase = true};
            var pageModel = new CreateModel(mockOnlineGroceryDeliveryContext.Object);
            Customer mockCustomer = new Customer { CustomerId = Int32.Parse("456"), LoginId = "mellis", Password = "hello", Name = "Michelle", Address = "200 Booker St.", Phone = "817-452-5428", Email = "mellis@yahoo.com" };

            // Act
            var result = await pageModel.OnPostAsync(mockCustomer);

            // Assert
            Assert.IsType<RedirectToPageResult>(result);
        }

    }
}