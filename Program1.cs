using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class SHEIN
    {
        static void Main(string[] args)
        {
            SHEIN shop = new SHEIN("Ксения", "Покупки");
            Console.WriteLine(shop.ReturnNameSHEIN());
            shop.SetName("Вера");
            Console.WriteLine(shop.ReturnNameSHEIN());
            Console.ReadLine();
        }
    }
}
