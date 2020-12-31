using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp
{
    class Common
    {
        public static string GetString(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }

        public static int GetNumber(string question)
        {
            int res = int.Parse(GetString(question));
            return res;
        }

        public static double GetDouble(string question)
        {
            double res = double.Parse(GetString(question));
            return res;
        }

        public static DateTime GetDate()
        {
            Console.WriteLine("Enter the Date as dd/MM/yyyy");
            return DateTime.Parse(Console.ReadLine());
        }

    }
}
