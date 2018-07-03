using System;
using System.Data;
using Adapter_pattern.Resource;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adapter.Tests
{
    [TestClass]
    public class MockDataTableFactoryTests
    {
        [TestMethod]
        public void ShouldReturnData()
        {
            //Arrage
            //Act
            var sut = MockDataTableFactory.GetCreateDataTable();

            //Asser
            MockDataTableFactory.CheckDataTable(sut);
        }
    }
}
