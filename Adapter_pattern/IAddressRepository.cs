using System.Collections.Generic;

namespace Adapter_pattern
{
    public interface IAddressRepository
    {
        IList<Address> GetAddresses();
    }
}