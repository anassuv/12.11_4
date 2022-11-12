using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N = ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("{0} -> ", n);
            for (int i = 2; i <= n; i++)
            {
                bool f = true;
                for (int x = 2; x <= i / 2 && f; x++)
                {
                    f = (i % x) != 0;
                }
                if (f)
                  Console.Write("{0}, ", i);
            }
            
            Console.ReadKey();
        }
    }
}
