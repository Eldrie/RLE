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

            Console.WriteLine("...");
            string cadena = (Console.ReadLine());

            for (int i = 0; i <= cadena.Length - 1; i++)
            {
             char c = cadena[i];

             Console.WriteLine(c);

            }
            Console.Read();
        }
    }
}
