using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime dt = DateTime.Now;
            //Console.WriteLine(dt);
            //Console.WriteLine(dt.ToString());
            //Console.WriteLine(dt.ToLongDateString());
            //Console.WriteLine(dt.ToShortDateString());
            //Console.WriteLine(dt.ToLongTimeString());
            //Console.WriteLine(dt.ToShortTimeString());
            //Console.WriteLine(dt.Ticks);
            //Console.WriteLine(dt.AddTicks(3).Ticks);
            //Console.WriteLine(dt.AddDays(3));


            //DateTime viafunc = new DateTime(2000, 10, 20);
            //Console.WriteLine(viafunc);

            //DateTime viaParse = DateTime.Parse("06-07-08");
            //Console.WriteLine(viaParse.Date);

            DateTime mybday = DateTime.Parse("12-07-1969");
            TimeSpan age = DateTime.Now.Subtract(mybday);
            Console.WriteLine(age.Days/365);
        }
    }
}
