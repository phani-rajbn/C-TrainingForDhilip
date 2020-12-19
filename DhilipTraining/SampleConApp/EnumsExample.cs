using System;
/*
 * Enums are named constants. They are integral values refered by a name
 * Months of an Year are fixed, names are also fixed and U can refer them by a name
 * Enums will increment the value by 1. It starts with 0 unless U set it to other value. 
 * Enums can be assigned with integral types only.
 */

namespace SampleConApp
{
    enum Months
    {
        Apr = 1, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec, Jan, Feb, Mar
    }
    class EnumsExample
    {
        static void Main(string[] args)
        {
            var startMonth = Months.Apr;
            var endMonth = Months.Mar;

            //Display all the values of the enum...
            Array all = Enum.GetValues(typeof(Months));
            foreach (var mon in all) Console.WriteLine(mon);
            Console.WriteLine("Enter one from the list above");
            Months selectedMonth = (Months)Enum.Parse(typeof(Months), Console.ReadLine());
            Console.WriteLine("The selected Month is " + selectedMonth);

        }
    }
}
