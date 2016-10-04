using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[4];

            for (int i = 0; i < num.Length; i++)
            {
                num[i] = 2 + i;

            }
            foreach (int accessNum in num)
            {
                if (accessNum % 2 == 0)
                {
                    Console.WriteLine(accessNum);
                }
            }
            string text = "I am Vishesh Sharma";
            char[] textArr = text.ToCharArray();
        
            foreach (char textItem in textArr)
            {
                Console.Write(textItem);
            }
            Console.ReadKey();


        }
    }
}
