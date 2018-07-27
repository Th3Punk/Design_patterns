using Adapter_pattern;
using System;

namespace Strategy_pattern
{
    public class DataService
    {
        private readonly IAddressRepository Repository;

        public DataService(AddressStrategyTestRepo repository)
        {
            this.Repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public int GetSumEmailCount()
        {
            var list = Repository.GetAddresses();

            var sum = 0;
            foreach (var item in list)
            {
                sum += item.EmailCount;
            }

            return sum;
        }
    }
}