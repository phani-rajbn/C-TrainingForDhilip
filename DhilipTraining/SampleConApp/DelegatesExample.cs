using System;
/*
 * U may require a function that takes another function as an argument.
 *  They are called Callback functions. 
 *  Delagates are used to create callback functions. 
 *  U can create UR own delegate and call it or U could use the .NET's Action or Func delegates. 
 *  If UR function takes a delegate object as its Arg, UR caller should create a function that matches the signature of UR delegate and pass it as argument to ur function...
 *  All Events that U see in GUI Development are based on Events. They are all instances of a Delegate called EventHandler.
 *  Uses: Event handling, Async Programming, Multi Threading are some of the practical usages of Delegates in .NET. 
 *  A Delegate instance can point to one or more functions at the same time. The delegate instance pointing to multiple functions is called MultiCast delegate. Use multicast delegates for void functions as the return value of the function cannot be captured for all the functions that are casted in delegate object. U only get the last result... 
 */
namespace SampleConApp
{
    delegate void funcType();

    delegate double MathOperation(double v1, double v2);

    class MathProgram
    {
        public static void InvokeMathOperation(MathOperation operation)
        {
            double num1 = Common.GetDouble("Enter First value");
            double num2 = Common.GetDouble("Enter Second value");
            double result = operation(num1, num2);
            Console.WriteLine("The result: " + result);
        }
    }
    class DelegatesExample
    {
        static double subFunc(double v1, double v2) => v1 - v2;
        static double addFunc(double v1, double v2) => v1 + v2;
        static void Main(string[] args)
        {
            //TestFunc(myFunc);
            MathProgram.InvokeMathOperation(addFunc);
            //using lambda Expression to instantiate a delegate...
            //multicastExample();
        }
        static void myFunc() => Console.WriteLine("SimpleExample");

        private static void multicastExample()
        {
            funcType ex = () => Console.WriteLine("Testing FuncType once");
            ex += () => Console.WriteLine("Testing FuncType with second function");
            ex += () => Console.WriteLine("Testing FuncType with third function");
            ex += () => Console.WriteLine("Testing FuncType with fouth function");

            ex();//call the delegate object. Delegate instance is more like an alias to Ur function...
        }
        static void TestFunc(funcType funcName)
        {
            Console.WriteLine("UR Implementation");
            funcName();//The function will be called inside the TestFunc...
            Console.WriteLine("Going Back");
        }
        
        
    }

   
}
