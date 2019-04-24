using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using UnitTestHomework00.Core.Tests.Common;

namespace UnitTestHomework00.Core.Tests
{
    [TestFixture]
    public class CreateUserRequestHandlerTests
    {
        [SetUp]
        public void Setup()
        {
        }

        // May be a test case
        [Test]
        public void Handle_UserHasFirstName_ReturnsDtoWithCorrectFirstName()
        {
            // Arrange
            var foo = new CreateUserRequest();
            foo.FirstName = "Matthew";

            // Act
            var classToTest = new CreateUserRequestHandler();
            var result = classToTest.Handle(foo);

            // Assert
            Assert.AreEqual(result.FirstName, "Matthew");
        }

        // May be a test case
        [Test]
        public void Handle_UserHasLastName_ReturnsDtoWithCorrectLastName()
        {
            // Arrage
            var request = new CreateUserRequest();
            request.LastName = "Picnic";

            // Act
            var classToTest = new CreateUserRequestHandler();
            var result = classToTest.Handle(request);


            // Assert (use ShouldBe like in FizzBuzzTests)
            Assert.AreEqual(result.LastName, "Picnic");
        }

        // May be a test case
        [Test]
        public void Handle_UserHasAge_ReturnsDtoWithCorrectAge()
        {
            int ageToTest = 26;
            // Arrage
            var request = new CreateUserRequest();
            request.Age = ageToTest;

            // Act
            var classToTest = new CreateUserRequestHandler();
            var result = classToTest.Handle(request);

            // Assert (use ShouldBe like in FizzBuzzTests)
            Assert.AreEqual(result.Age, ageToTest);
        }
    }
}
