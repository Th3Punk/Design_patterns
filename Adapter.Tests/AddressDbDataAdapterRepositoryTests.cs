using System;
using System.Data;
using Adapter_pattern;
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
            AddressDBDataAdapterRepository sut;
            Action todo = () => sut = new AddressDBDataAdapterRepository(null);

            todo.Should().Throw<ArgumentNullException>();
        }
    }
}
