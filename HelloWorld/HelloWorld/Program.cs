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
            /* 
             Console.WriteLine("Hello World");
             Console.WriteLine("who is there");
             string firstname=Console.ReadLine();
             string lastname=Console.ReadLine();

             Console.WriteLine("Hey " + firstname + " " + lastname);
             Console.ReadKey();
             */

             //Program for learning Argument passing..
            int userValue = 2;
            string message = (userValue == 2) ? "boat" : "car";
            string vishesh = "me";
            Console.WriteLine("{2}-{1}-{0}",message,userValue,vishesh); //args are passed in inc order.. O,1,2..
                                                                      //can be used in any ordr. but passed in inc.
            Console.ReadKey();
        }
    }
}
