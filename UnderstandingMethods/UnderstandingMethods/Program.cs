using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingMethods
{
    class Program
    {
        static void Main(string[] args)
        {Console.WriteLine("The Name Game");

            Console.Write("What's your first name? ");
            string firstName = Console.ReadLine();

            Console.Write("What's your last name? ");
            string lastName = Console.ReadLine();

            Console.Write("In what city were you born?");
            string city = Console.ReadLine();
            
            Console.WriteLine("Results: ");
            toArrRev(firstName);
            toArrRev(lastName);
            toArrRev(city);

            Console.ReadLine();

            
        }

        static void toArrRev(string a)
        {
            char[] aArr = a.ToCharArray();
            Array.Reverse(aArr);
            foreach (char aArrItem in aArr)
            {
                Console.Write(aArrItem);
            }
            Console.Write(" ");
        }
    }
}
