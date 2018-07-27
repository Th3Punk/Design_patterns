using System;
using System.Data;
using Adapter_pattern;
using Adapter_pattern.Resource;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.OleDb;

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
        public void ShouldReturnedMockData()
        {
            //Arrage
            var adapter = new MockDbDataAdapter(MockDataTableFactory.GetCreateDataTable());
            AddressDBDataAdapterRepository sut = new AddressDBDataAdapterRepository(adapter);

            //Act
            var list = sut.GetAddresses();

            //Assert
            list.Should().HaveCount(1, "mert 1 elem került a repoba")
                //.And
                //.Should().Equals(new Address { EMail = GlobalStrings.TestEmailAddress })
                ;
        }

        [TestMethod]
        public void ShouldReturnedSQLData()
        {
            //Arrage
            var adapter = new OleDbDataAdapter
            {
                SelectCommand = new OleDbCommand($"select * from {GlobalStrings.TableName}")
            };
            adapter.SelectCommand.Connection = new OleDbConnection(@"Provider=sqloledb;Data Source=.\punkserver;Initial Catalog=Addresses; Integrated Security = SSPI; ");
            

            AddressDBDataAdapterRepository sut = new AddressDBDataAdapterRepository(adapter);

            //Act
            var list = sut.GetAddresses();

            //Assert
            list.Should().HaveCount(1, "mert 1 elem került a repoba")
                //.And
                //.Should().Equals(new Address { EMail = GlobalStrings.TestEmailAddress })
                ;
        }
    }
}
