using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_pattern
{
    /// <summary>
    /// Feladat: Körüzenet küldő alkalmazás
    /// Rendelkezésre áll: DB, üzenet küldő szolgáltatás (mail, sms chat)
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var example = new AdapterExample(new AddressTestRepository(), new MessageTestService());
            example.Start();

            Console.ReadKey();
        }
    }
}
