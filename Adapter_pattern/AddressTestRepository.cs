using System;
using System.Collections.Generic;

namespace Adapter_pattern
{
    public class AddressTestRepository : IAddressRepository
    {
        public AddressTestRepository()
        {
        }

        public IList<Address> GetAddresses()
        {
            return new List<Address> { new Address { EMail = "sitkei.balazs92@gmail.com" } };
        }
    }
}