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
        public void ShouldMockThrowIfArgumentNull()
        {
            //Arrage
            var sut = new MockDbDataAdapter();

            //Act
            Action todo = () => sut.Fill(null);

            //Asser
            todo.Should().Throw<ArgumentNullException>();
        }

        [TestMethod]
        public void MockShouldReturnedOneTable()
        {
            //Arrage
            var sut = new MockDbDataAdapter();
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
            var sut = new MockDbDataAdapter();
            var dataSet = new DataSet();

            //Act
            sut.Fill(dataSet);

            //Asser
            dataSet.Tables.Should().HaveCount(1, "Mert egy táblával kell visszatérni");

            var table = dataSet.Tables[0];
            table.Rows.Should().HaveCount(1, "Mert a táblában kell lennie egy sornak");
            table.Columns[GlobalStrings.TableColumnEMailAddress].Should().NotBeNull();
            table.Rows[0][GlobalStrings.TableColumnEMailAddress].Should().Be(GlobalStrings.TestEmailAddress);
        }
    }
}
