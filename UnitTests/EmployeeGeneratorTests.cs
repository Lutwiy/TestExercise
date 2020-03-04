using Moq;

using NUnit.Framework;

using TestExercise.Generator;

namespace UnitTests
{
    public class Tests
    {
        [Test]
        public void GetEmployee_ReturnEmployee()
        {
            // Arrange
            var name = new Mock<INameGenerator>();
            name.SetupGet(r => r.NextName).Returns("TestName");
            var secondName = new Mock<INameGenerator>();
            secondName.SetupGet(r => r.NextName).Returns("TestFamilie");

            var generator = new EmployeeGenerator(name.Object, secondName.Object);
            // Act
            var employee = generator.GetEmployee(1);
            // Assert
            Assert.AreEqual(employee.Pin, 1);
            Assert.AreEqual(employee.FirstName, "TestName");
            Assert.AreEqual(employee.SecondName, "TestFamilie");
        }
    }
}