using System;
//Most of the features of C# comes from C++.
namespace SampleConApp
{
    class DataTypes
    {
        static void Main()
        {
            //firstExample();
        }

        private static void firstExample()
        {
            //integral types: byte, short, int, long
            //floating types: float, double, decimal
            //other types: char, bool. 
            //structs and enums. 
            //MinValue, MaxValue, ToString(), Parse and TryParse

            int value = 123;
            long lValue = value;//implicit casting....
            int someotherint = (int)lValue;//This is called as casting.
            //int intvalue = Convert.ToInt32(lValue);//recommended practise of type conversion in C#..
            //Functions of the Convert class and how many overloads are available for each function. This is one common class for types of safe conversoins in .NET

            //INputs will be always string. string can be converted to its value type using Parse method...

            int nvalue = int.Parse(Console.ReadLine());
        }
    }
}
