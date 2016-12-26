using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            String name = Console.ReadLine();
            if (name == "karim")
            {
                Console.WriteLine("Hello, " + name);
            }
            else
            {
                Console.WriteLine("Bye, " + name);
            }
            Console.ReadLine();

            ;
        }
    }
}
