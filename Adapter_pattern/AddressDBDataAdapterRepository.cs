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
            throw new NotImplementedException();
        }
    }
}