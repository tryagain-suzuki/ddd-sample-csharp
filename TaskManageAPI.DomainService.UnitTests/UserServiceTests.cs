using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskManageAPI.DomainService;
using System;
using System.Collections.Generic;
using System.Text;
using Moq;
using TaskManageAPI.DomainService.Interface;
using TaskManageAPI.DomainModel;

namespace TaskManageAPI.DomainService.Tests
{
    [TestClass()]
    public class UserServiceTests
    {
        [TestMethod()]
        public void IsDuplicatedTest_case_false()
        {
            // Arrange
            var moc = new Mock<IUserRepository>();
            moc.Setup(repo => repo.Get())
                .Returns(new List<User>() { 
                    new User() { 
                        email = "ex@example.com" 
                    }
                });

            // Act
            var result = new UserService(moc.Object).IsDuplicated("false@example.com");

            // Assert
            Assert.AreEqual(false, result);
        }
    }
}