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
            /*
           int userValue = 2;
           string message = (userValue == 2) ? "boat" : "car";
           string vishesh = "me";
           Console.WriteLine("{2}-{1}-{0}",message,userValue,vishesh); //args are passed in inc order.. O,1,2..
                                                                     //can be used in any ordr. but passed in inc.
           Console.ReadKey();
           */


            //Program to learn if-else, for loop, break..

            Console.WriteLine("Enter string a::::  ");
            string a =Console.ReadLine();
            Console.WriteLine("Enter string b::::  ");
            string b= Console.ReadLine();

            int compareDiff = a.Length - b.Length;
            if (compareDiff < 0)
            {
                compareDiff = -compareDiff;
            }

            if (a.Length < b.Length)
            {
                Console.WriteLine("B is bigger by "+ compareDiff);
            } 
            else if(a.Length>b.Length)
            {
                Console.WriteLine("A is bigger by "+ compareDiff);
            }
            else
            {
                Console.WriteLine("Both are equal");
            }


            for (int i = 1; i <= compareDiff; i++)
            {
                Console.WriteLine("You have " + (compareDiff - i) + " strings to enter!:");
                string DiffEnter = Console.ReadLine();
                if (string.IsNullOrEmpty(DiffEnter) == true)
                {
                    Console.WriteLine("You didn't entered anything!.. BYE");
                    break;
                }
                else
                {
                    Console.WriteLine("You just entered " + DiffEnter);
                }
            }
            Console.WriteLine("Time to say BYE");
            Console.ReadKey(); 
        }
    }
}
