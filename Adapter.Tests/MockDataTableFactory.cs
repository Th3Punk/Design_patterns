﻿using Adapter_pattern.Resource;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Tests
{
    class MockDataTableFactory
    {
        public static DataTable GetCreateDataTable()
        {
            var dataTable = new DataTable();

            dataTable.Columns.Add(GlobalStrings.TableColumnEMailAddress, typeof(string));
            var row = dataTable.NewRow();
            row[GlobalStrings.TableColumnEMailAddress] = GlobalStrings.TestEmailAddress;
            dataTable.Rows.Add(row);
            return dataTable;
        }

        public static void CheckDataTable(DataTable table)
        {
            table.Rows.Should().HaveCount(1, "Mert a táblában kell lennie egy sornak");
            table.Columns[GlobalStrings.TableColumnEMailAddress].Should().NotBeNull();
            table.Rows[0][GlobalStrings.TableColumnEMailAddress].Should().Be(GlobalStrings.TestEmailAddress);
        }
    }
}
