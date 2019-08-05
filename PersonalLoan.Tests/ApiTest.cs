using Moq;
using PersonalLoan.Controllers;
using PersonalLoan.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace PersonalLoan.Tests
{
    /// <summary>
    /// The test class covers test cases for the Api Controller.
    /// </summary>
    public class ApiTest
    {
        /// <summary>
        /// The below test method tests if the mapping with the db returned object is happening properly.
        /// A mock object is set to return a single record simulating the database context
        /// </summary>
        [Fact]
        public void TestGetLoanDetails()
        {
            var mockRep = new Mock<IPersonalLoanDetailsRepository>();
            List<Data.Models.PersonalLoanDetail> retVal = new List<Data.Models.PersonalLoanDetail> {
                   new Data.Models.PersonalLoanDetail
                   {
                       AccountNumber=111111,
                   }
            };
            mockRep.Setup(c => c.GetPersonalLoanDetails(It.IsAny<long>())).Returns(retVal);
            UserLoanController obj = new UserLoanController(mockRep.Object);
            var currentResult = obj.UserDetail(1);

            int actualCount = currentResult.Select(c => c.Id).Count();
            int expectedCount = 1;
            Assert.Equal(actualCount, expectedCount);
        }

        /// <summary>
        /// The below methos tests if the order number is calculated properly.
        /// </summary>
        [Fact]
        public void TestGetLoanDetailsOrderNumber()
        {
            var mockRep = new Mock<IPersonalLoanDetailsRepository>();
            List<Data.Models.PersonalLoanDetail> retVal = new List<Data.Models.PersonalLoanDetail> {
                   new Data.Models.PersonalLoanDetail
                   {
                       AccountNumber=111111,
                   }
            };
            mockRep.Setup(c => c.GetPersonalLoanDetails(It.IsAny<long>())).Returns(retVal);
            UserLoanController obj = new UserLoanController(mockRep.Object);
            var currentResult = obj.UserDetail(1);

            int actualNumber = currentResult.Select(c => c.OrderNumber).FirstOrDefault();
            int expectedNumber = 1;
            Assert.Equal(actualNumber, expectedNumber);
        }
    }
}
