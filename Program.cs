using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class SHEIN
    {
        string Name;
        double number;
        string purchases;

        public SHEIN(string name, double number, string purchases)
        {
            Name = name;
            this.number = number;
            this.purchases = purchases;
        }
        public string Sum(int a, int b)
        {
            return (a + b).ToString();
        }
        private string ReturnNameSHEIN()
        {
            return Name;
        }
    }
}
