using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringtutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //String a = String.Format(" Shown as Numeric: {0:N}", 12342342423.45);
            //String a = String.Format("Percentage: {0:P}", .4523);
            /*
            int x = int.Parse(Console.ReadLine());
            double n = Math.Floor(Math.Log10(x) + 1);
            Console.WriteLine(n);
            */

            //printing an Indian mobile number as +91 ** ** ******
            Int64 a = int.Parse(Console.ReadLine());
            Console.WriteLine(String.Format(":: {0: ## ## ## ## ##}", a));

            double n = Math.Floor(Math.Log10(a) + 1);
            Console.WriteLine(n);
            if (n == 10)
            {
                Console.WriteLine(String.Format("You mobile num: +91 {0: ## ## ######}", a));
            }
            Console.ReadLine();
        }
    }
}