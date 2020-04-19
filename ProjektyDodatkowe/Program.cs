using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektyDodatkowe
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2017, 1, 1);

           
            for (int i = 0; i < 84; i++)
            {
                bool a = dt.ToString("MM").Equals("03");
                if (a != true)
                {
                    Console.WriteLine(dt.ToString("yyyy'-'MM"));
                }
                dt = dt.AddMonths(1);
            }
            Console.ReadLine();
        }
    }
}
