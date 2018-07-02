using System;
using System.Data;
using Adapter_pattern;
using Adapter_pattern.Resource;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adapter.Tests
{
    [TestClass]
    public class AddressDbDataAdapterRepositoryTests
    {
        [TestMethod]
        public void ShouldThrowIfArgumentNull()
        {
            //Arrage
            AddressDBDataAdapterRepository sut;

            //Act
            Action todo = () => sut = new AddressDBDataAdapterRepository(null);

            //Assert
            todo.Should().Throw<ArgumentNullException>();
        }

        [TestMethod]
        public void ShouldReturnedData()
        {
            //Arrage
            var adapter = new MockDbDataAdapter();
            AddressDBDataAdapterRepository sut = new AddressDBDataAdapterRepository(adapter);

            //Act
            var list = sut.GetAddresses();

            //Assert
            list.Should().HaveCount(1, "mert 1 elem került a repoba")
                .And
                .Should().Equals(new Address { EMail = GlobalStrings.TestEmailAddress });
        }
    }
}
