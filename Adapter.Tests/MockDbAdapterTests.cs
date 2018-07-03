using System;
using System.Data;
using Adapter_pattern;
using Adapter_pattern.Resource;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adapter.Tests
{
    [TestClass]
    public class MockDbAdapterTests
    {
        [TestMethod]
        public void ShouldMockThrowIfCtorArgumentNull()
        {
            //Arrage
            MockDbDataAdapter sut;

            //Act
            Action todo = () => sut = new MockDbDataAdapter(null);

            //Asser
            todo.Should().Throw<ArgumentNullException>();
        }

        [TestMethod]
        public void ShouldMockThrowIfFillArgumentNull()
        {
            //Arrage
            var sut = new MockDbDataAdapter(MockDataTableFactory.GetCreateDataTable());

            //Act
            Action todo = () => sut.Fill(null);

            //Asser
            todo.Should().Throw<ArgumentNullException>();
        }

        [TestMethod]
        public void MockShouldReturnedOneTable()
        {
            //Arrage
            var sut = new MockDbDataAdapter(MockDataTableFactory.GetCreateDataTable());
            var dataSet = new DataSet();

            //Act
            sut.Fill(dataSet);

            //Asser
            dataSet.Tables.Should().HaveCount(1);
        }

        [TestMethod]
        public void MockShouldReturnedData()
        {
            //Arrage
            var sut = new MockDbDataAdapter(MockDataTableFactory.GetCreateDataTable());
            var dataSet = new DataSet();

            //Act
            sut.Fill(dataSet);

            //Asser
            dataSet.Tables.Should().HaveCount(1, "Mert egy táblával kell visszatérni");

            var table = dataSet.Tables[0];
            MockDataTableFactory.CheckDataTable(table);
        }
    }
}
