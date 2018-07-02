using Adapter_pattern.Resource;
using System;
using System.Collections.Generic;
using System.Data;

namespace Adapter_pattern
{
    public class AddressDBDataAdapterRepository : IAddressRepository
    {
        private readonly IDbDataAdapter Adapter;

        public AddressDBDataAdapterRepository(IDbDataAdapter _adapter)
        {
            this.Adapter = _adapter ?? throw new ArgumentNullException(nameof(_adapter));
        }

        public IList<Address> GetAddresses()
        {
            var dataSet = new DataSet();
            Adapter.Fill(dataSet);

            var list = new List<Address>();

            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                list.Add(new Address { EMail = row.Field<string>(GlobalStrings.TableColumnEMailAddress) });
            }

            return list;
        }
    }
}