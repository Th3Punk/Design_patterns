using Adapter_pattern.Resource;
using System;
using System.Data;

namespace Adapter.Tests
{
    public class MockDbDataAdapter : IDbDataAdapter
    {
        private DataTable dataTable;

        public MockDbDataAdapter(DataTable _dataTable)
        {
            dataTable = _dataTable ?? throw new ArgumentNullException(nameof(_dataTable));
        }

        public int Fill(DataSet dataSet)
        {
            if (dataSet == null) { throw new ArgumentNullException(nameof(dataSet)); }

            dataSet.Tables.Add(dataTable);
            dataSet.AcceptChanges();

            return dataTable.Rows.Count;
        }

        #region not implemented
        public IDbCommand SelectCommand { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public IDbCommand InsertCommand { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public IDbCommand UpdateCommand { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public IDbCommand DeleteCommand { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public MissingMappingAction MissingMappingAction { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public MissingSchemaAction MissingSchemaAction { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public ITableMappingCollection TableMappings => throw new System.NotImplementedException();


        public DataTable[] FillSchema(DataSet dataSet, SchemaType schemaType)
        {
            throw new System.NotImplementedException();
        }

        public IDataParameter[] GetFillParameters()
        {
            throw new System.NotImplementedException();
        }

        public int Update(DataSet dataSet)
        {
            throw new System.NotImplementedException();
        }
        #endregion
    }
}