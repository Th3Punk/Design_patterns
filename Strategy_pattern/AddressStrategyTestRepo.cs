using Adapter_pattern;
using Adapter_pattern.Resource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_pattern
{
    public class AddressStrategyTestRepo : IAddressRepository
    {
        public IList<Address> GetAddresses()
        {
            return new List<Address>
            {
                new Address { EMail = GlobalStrings.TestEmailAddress1, EmailCount = 1 },
                new Address { EMail = GlobalStrings.TestEmailAddress2, EmailCount = 7 },
                new Address { EMail = GlobalStrings.TestEmailAddress3, EmailCount = 4 },
                new Address { EMail = GlobalStrings.TestEmailAddress4, EmailCount = 7 },
                new Address { EMail = GlobalStrings.TestEmailAddress5, EmailCount = 6 },
                new Address { EMail = GlobalStrings.TestEmailAddress6, EmailCount = 3 },
                new Address { EMail = GlobalStrings.TestEmailAddress7, EmailCount = 21 },
                new Address { EMail = GlobalStrings.TestEmailAddress8, EmailCount = 3 },
                new Address { EMail = GlobalStrings.TestEmailAddress9, EmailCount = 2 }
            };
        }
    }
}
