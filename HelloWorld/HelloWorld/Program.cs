using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello World");
            Console.WriteLine("who is there");
            string firstname=Console.ReadLine();
            string lastname=Console.ReadLine();

            Console.WriteLine("Hey " + firstname + " " + lastname);
            Console.ReadKey();
        }
    }
}
