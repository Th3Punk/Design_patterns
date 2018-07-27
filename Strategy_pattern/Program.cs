using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_pattern
{
    /// <summary>
    /// A feladat külömböző algoritmusok beépítése a rendszerbe
    /// -kérjük le, hogy hány mail-t küldtünk a rendszerben
    /// -átlagossan nány mailt küldtünk egyes címzetteknek
    /// -mail küldése egy csoportnak
    /// -az üzenet szövege plain text legyen 
    /// -html legyen az üzenet
    /// -...
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var service = new DataService(new AddressStrategyTestRepo());

            //kérjük le, hogy hány mail-t küldtünk a rendszerben
            var count = service.GetSumEmailCount();

            Console.WriteLine($"E-mailek száma: { count }");

            Console.ReadKey();
        }
    }
}
