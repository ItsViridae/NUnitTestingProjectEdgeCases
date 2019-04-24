using NUnit.Framework;
using UnitTestHomework00;
using UnitTestHomework00.Core.Tests.Common;

namespace Tests
{
    public class FizzBuzzTests
    {
        [SetUp]
        public void Setup()
        {
        }
        
        [TestCase(-13)]
        [TestCase(-4)]
        [TestCase(-2)]
        [TestCase(2)]
        [TestCase(7)]
        [TestCase(26)]
        public void Hnalde_GivenANumberThatIsNotDivisbleByThreeOrFive_ReturnsEmptyString(int value)
        {
            // Arrage
            var expected = "";
            var classUnderTest = new FizzBuzz();

            // Act
            var result = classUnderTest.Handle(value);

            // Assert
            result.ShouldBe(expected);
        }

        [TestCase(-3)]
        [TestCase(3)]
        [TestCase(6)]
        [TestCase(27)]
        public void Hnalde_GivenANumberThatIsDivisbleByThreeButNotFive_ReturnsFizz(int value)
        {
            // Arrage
            var expected = "Fizz";
            var classUnderTest = new FizzBuzz();

            // Act
            var result = classUnderTest.Handle(value);

            // Assert
            result.ShouldBe(expected);
        }

        [TestCase(-20)]
        [TestCase(-10)]
        [TestCase(-5)]
        [TestCase(5)]
        [TestCase(10)]
        [TestCase(20)]
        public void Hnalde_GivenANumberThatIsNotDivisbleByThreeButIsDivisbleFive_ReturnsBuzz(int value)
        {
            // Arrage
            var expected = "Buzz";
            var classUnderTest = new FizzBuzz();

            // Act
            var result = classUnderTest.Handle(value);

            // Assert
            result.ShouldBe(expected);
        }

        [TestCase(-30)]
        [TestCase(-15)]
        [TestCase(0)]
        [TestCase(15)]
        [TestCase(30)]
        public void Hnalde_GivenANumberThatIsDivisbleByThreeAndFive_ReturnsFizzBuzz(int value)
        {
            // Arrage
            var expected = "FizzBuzz";
            var classUnderTest = new FizzBuzz();

            // Act
            var result = classUnderTest.Handle(value);

            // Assert
            result.ShouldBe(expected);
        }
    }
}