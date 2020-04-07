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
            //Call func to convert DateTime to Ticks 
            string Data = Convert.ToString(DateTime.Now);
            System.Console.WriteLine("Data now:" + Data);
            long ticks = ConvertDateTimeToTicks(DateTime.Now);
            System.Console.WriteLine("Ticks now: " + ticks.ToString());
            System.Console.WriteLine("Enter your Ticks to convert to Data(636130667957896046): ");
            long MyTicks = Convert.ToInt64(Console.ReadLine());
            //Call fun to convert Ticks to DateTime 
            DateTime dt = ConvertTicksToDateTime(MyTicks);
            //636130667957896046
            System.Console.WriteLine("Your data:" + dt.ToString());
            System.Console.WriteLine("Enter your Data to convert to Ticks(01.01.2020 13:05:05): ");
            System.DateTime MyData = Convert.ToDateTime(Console.ReadLine());
            long TiksMyData = ConvertDateTimeToTicks(MyData);
            System.Console.WriteLine("Your data to Ticks:" + TiksMyData.ToString());
            System.Console.Read();
        }

        public static long ConvertDateTimeToTicks(DateTime dtInput)
        {
            long ticks = 0;
            ticks = dtInput.Ticks;
            return ticks;
        }
        public static DateTime ConvertTicksToDateTime(long lticks)
        {
            DateTime dtresult = new DateTime(lticks);
            return dtresult;
        }
    }
}