using Acme.Sample.App.Controllers;
using Acme.Sample.Core.Tests;
using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;

namespace Acme.Sample.App.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            TestHelper.Foo();
        }

        [Test]
        public void Test1()
        {
            var controller = new WeatherForecastController(new Mock<ILogger<WeatherForecastController>>().Object);

            Assert.Pass();
        }
    }
}