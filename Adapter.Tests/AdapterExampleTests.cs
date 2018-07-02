using System;
using Adapter_pattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;

namespace Adapter.Tests
{
    [TestClass]
    public class AdapterExampleTests
    {
        [TestMethod]
        public void ShouldThrowExceptionIfAllArgumentNull()
        {
            //var sut = new AdapterExample(null, null);
            AdapterExample sut;
            Action todo = () => sut = new AdapterExample(null, null);

            todo.Should().Throw<ArgumentNullException>();
        }

        [TestMethod]
        public void ShouldThrowExceptionIfFirstArgumentNull()
        {
            //var sut = new AdapterExample(null, null);
            AdapterExample sut;
            Action todo = () => sut = new AdapterExample(null, new MessageTestService());

            todo.Should().Throw<ArgumentNullException>();
        }

        [TestMethod]
        public void ShouldThrowExceptionIfSeconfArgumentNull()
        {
            //var sut = new AdapterExample(null, null);
            AdapterExample sut;
            Action todo = () => sut = new AdapterExample(new AddressTestRepository(), null);

            todo.Should().Throw<ArgumentNullException>();
        }
    }
}
