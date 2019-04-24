using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnitTestHomework00.Core.Homework02;
using UnitTestHomework00.Core.Tests.Common;

namespace UnitTestHomework00.Core.Tests.Homework02
{
    [TestFixture]
    public class MessyToCleanTests
    {
        [Test]
        public void CleanAddresses_TwoMessyAddressesSentIn_SameNumberOfCleanAddessesReturned()
        {
            // Arrange
            var messyAddresses = new List<MessyAddressInformation>();
            messyAddresses.Add(new MessyAddressInformation());
            messyAddresses.Add(new MessyAddressInformation());

            // Act
            var classToTest = new MessyListToCleanList();
            var result = classToTest.CleanAddresses(messyAddresses);

            // Assert
            result.Count.ShouldBe(2);
        }

        [Test]
        public void CleanAddresses_ThreeMessyAddressesSentIn_SameNumberOfCleanAddessesReturned()
        {
            // Arrange
            var messyAddresses = new List<MessyAddressInformation>();
            messyAddresses.Add(new MessyAddressInformation());
            messyAddresses.Add(new MessyAddressInformation());
            messyAddresses.Add(new MessyAddressInformation());

            // Act
            var classToTest = new MessyListToCleanList();
            var result = classToTest.CleanAddresses(messyAddresses);

            // Assert
            result.Count.ShouldBe(3);
        }

        [Test]
        public void CleanAddresses_MessyAddressHasName_SplitsNameOnSpacesAndStoresCorrentValueIntoFirstName()
        {
            // Arrange
            var name = "Matthew Puneky";

            var messyAddresses = new List<MessyAddressInformation>();
            messyAddresses.Add(new MessyAddressInformation { Name = name });
            
            // Act
            var classToTest = new MessyListToCleanList();
            var result = classToTest.CleanAddresses(messyAddresses);

            // Assert
            result.Any(x => x.FirstName == "Matthew").ShouldBe(true);
        }

        [Test]
        public void CleanAddresses_MessyAddressHasName_SplitsNameOnSpacesAndStoresCorrentValueIntoLastName()
        {
            // Arrange
            var name = "Matthew Puneky";

            var messyAddresses = new List<MessyAddressInformation>();
            messyAddresses.Add(new MessyAddressInformation { Name = name });

            // Act
            var classToTest = new MessyListToCleanList();
            var result = classToTest.CleanAddresses(messyAddresses);

            // Assert
            result.Any(x => x.LastName == "Puneky").ShouldBe(true);
        }

        [Test]
        public void CleanAddresses_MessyAddressHasNameWithOnlyFirstName_FirstNameHasSentInValue()
        {
            // Arrange
            var name = "Matthew";

            var messyAddresses = new List<MessyAddressInformation>();
            messyAddresses.Add(new MessyAddressInformation { Name = name });

            // Act
            var classToTest = new MessyListToCleanList();
            var result = classToTest.CleanAddresses(messyAddresses);

            // Assert
            result.Any(x => x.FirstName == "Matthew").ShouldBe(true);
        }

        [Test]
        public void CleanAddresses_MessyAddressHasNameWithOnlyFirstName_LastNameHasValueOfNA()
        {
            // Arrange
            var name = "Matthew";

            var messyAddresses = new List<MessyAddressInformation>();
            messyAddresses.Add(new MessyAddressInformation { Name = name });

            // Act
            var classToTest = new MessyListToCleanList();
            var result = classToTest.CleanAddresses(messyAddresses);

            // Assert
            result.Any(x => x.LastName == "N/A").ShouldBe(true);
        }

        [Test]
        public void CleanAddresses_MessyAddressHasNameOfNothing_FirstNameHasValueOfNA()
        {
            // Arrange
            var name = "";

            var messyAddresses = new List<MessyAddressInformation>();
            messyAddresses.Add(new MessyAddressInformation { Name = name });

            // Act
            var classToTest = new MessyListToCleanList();
            var result = classToTest.CleanAddresses(messyAddresses);

            // Assert
            result.Any(x => x.FirstName == "N/A").ShouldBe(true);
        }

        [Test]
        public void CleanAddresses_MessyAddressHasNameOfNothing_LastNameHasValueOfNA()
        {
            // Arrange
            var name = "";

            var messyAddresses = new List<MessyAddressInformation>();
            messyAddresses.Add(new MessyAddressInformation { Name = name });

            // Act
            var classToTest = new MessyListToCleanList();
            var result = classToTest.CleanAddresses(messyAddresses);

            // Assert
            result.Any(x => x.LastName == "N/A").ShouldBe(true);
        }

        [Test]
        public void CleanAddresses_MessyAddressHasAddress_SplitsAdressOnCommasAndStoresCorrentValueIntoStreetAddress()
        {
            // Arrange
            var address = "42 Foo Dr., Some City, NY, 98210";

            var messyAddresses = new List<MessyAddressInformation>();
            messyAddresses.Add(new MessyAddressInformation { Address = address });

            // Act
            var classToTest = new MessyListToCleanList();
            var result = classToTest.CleanAddresses(messyAddresses);

            // Assert
            result.Any(x => x.StreetAddres == "42 Foo Dr.").ShouldBe(true);
        }

        [Test]
        public void CleanAddresses_MessyAddressHasAddress_SplitsAdressOnCommasAndStoresCorrentValueIntoCity()
        {
            // Arrange
            var address = "42 Foo Dr., Some City, NY, 98210";

            var messyAddresses = new List<MessyAddressInformation>();
            messyAddresses.Add(new MessyAddressInformation { Address = address });

            // Act
            var classToTest = new MessyListToCleanList();
            var result = classToTest.CleanAddresses(messyAddresses);

            // Assert
            result.Any(x => x.City == "Some City").ShouldBe(true);
        }

        [Test]
        public void CleanAddresses_MessyAddressHasAddress_SplitsAdressOnCommasAndStoresCorrentValueIntoState()
        {
            // Arrange
            var address = "42 Foo Dr., Some City, NY, 98210";

            var messyAddresses = new List<MessyAddressInformation>();
            messyAddresses.Add(new MessyAddressInformation { Address = address });

            // Act
            var classToTest = new MessyListToCleanList();
            var result = classToTest.CleanAddresses(messyAddresses);

            // Assert
            result.Any(x => x.State == "NY").ShouldBe(true);
        }

        [Test]
        public void CleanAddresses_MessyAddressHasAddress_SplitsAdressOnCommasAndStoresCorrentValueIntoZipCode()
        {
            // Arrange
            var address = "42 Foo Dr., Some City, NY, 98210";

            var messyAddresses = new List<MessyAddressInformation>();
            messyAddresses.Add(new MessyAddressInformation { Address = address });

            // Act
            var classToTest = new MessyListToCleanList();
            var result = classToTest.CleanAddresses(messyAddresses);

            // Assert
            result.Any(x => x.ZipCode == "98210").ShouldBe(true);
        }

        [Test]
        public void CleanAddresses_MessyAddressHasAddressOfNothing_StreetAddressHasValueOfNA()
        {
            // Arrange
            var address = "";

            var messyAddresses = new List<MessyAddressInformation>();
            messyAddresses.Add(new MessyAddressInformation { Address = address });

            // Act
            var classToTest = new MessyListToCleanList();
            var result = classToTest.CleanAddresses(messyAddresses);

            // Assert
            result.Any(x => x.StreetAddres == "N/A").ShouldBe(true);
        }

        [Test]
        public void CleanAddresses_MessyAddressHasAddressOfNothing_CityHasValueOfNA()
        {
            // Arrange
            var address = "";

            var messyAddresses = new List<MessyAddressInformation>();
            messyAddresses.Add(new MessyAddressInformation { Address = address });

            // Act
            var classToTest = new MessyListToCleanList();
            var result = classToTest.CleanAddresses(messyAddresses);

            // Assert
            result.Any(x => x.City == "N/A").ShouldBe(true);
        }

        [Test]
        public void CleanAddresses_MessyAddressHasAddressOfNothing_StateHasValueOfNA()
        {
            // Arrange
            var address = "";

            var messyAddresses = new List<MessyAddressInformation>();
            messyAddresses.Add(new MessyAddressInformation { Address = address });

            // Act
            var classToTest = new MessyListToCleanList();
            var result = classToTest.CleanAddresses(messyAddresses);

            // Assert
            result.Any(x => x.State == "N/A").ShouldBe(true);
        }

        [Test]
        public void CleanAddresses_MessyAddressHasAddressOfNothing_ZipCodeHasValueOfNA()
        {
            // Arrange
            var address = "";

            var messyAddresses = new List<MessyAddressInformation>();
            messyAddresses.Add(new MessyAddressInformation { Address = address });

            // Act
            var classToTest = new MessyListToCleanList();
            var result = classToTest.CleanAddresses(messyAddresses);

            // Assert
            result.Any(x => x.ZipCode == "N/A").ShouldBe(true);
        }
    }
}
