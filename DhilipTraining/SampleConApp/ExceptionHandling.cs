using System;
using System.IO;
/*
 * Exception handling is handling scenarios where UR app fails to execute due to a wrong logic, wrong inputs that might not suit the execution or the system fails to take it forward. 
 * Exceptions are raised by the CLR using objects of a class derived from System.Exception.
 * There are 2 types: System Generated Exceptions and Application Exceptions. Application Exceptions are user defined Exceptions that are raised due to the app requirement. 
 * Ur code can raise an Exception using throw keyword followed by an object of the Exception class with a message on why the exception has raised. 
 * Any code that U use raises an Exception, U should catch that exception using try...catch...finally blocks...
 * try must have catch or finally or both.
 * try block is the section of the code that U want to execute, but could raise an Exception. 
 * catch block contains the Exception handling block. U can have multiple catch blocks to suit various kinds of Exceptions. 
 * finally block is optional and will run all the time irrespective whether an Exception occurs or not. It is more like a cleanup Operation..
 * Exceptions that are not caught are unhandled and will stop the program from executing. 
 */
namespace SampleConApp
{
    class ExceptionHandling
    {
        static void Main(string[] args)
        {
            //usingTryCatchFinally();
            //usingMultipleCatchExample();
            //usingDivideByZeroException();
            //FileHandlingExceptionExample();
            //Custom Exceptions will be covered later.
        }

        private static void FileHandlingExceptionExample()
        {
            try
            {
                string data = File.ReadAllText("Example.txt");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("This file does not exist");
            }
        }

        private static void usingDivideByZeroException()
        {
            Console.WriteLine("Lets write a Division program");
            TRYAGAIN:
            try
            {
                int num1 = Common.GetNumber("Enter First Value");
                int num2 = Common.GetNumber("Enter Second Value");
                int res = num1 / num2;
                Console.WriteLine(res);
            }
            catch (FormatException)
            {
                Console.WriteLine("Input is not a valid Integer, Please try again");
                goto TRYAGAIN;
            }
            catch (OverflowException)
            {
                Console.WriteLine($"Integer value should be within the range of {int.MinValue} and {int.MaxValue}");
                goto TRYAGAIN;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Denominator should not be zero while U divide a number. Please try again");
                goto TRYAGAIN;
            }
        }

        private static void usingMultipleCatchExample()
        {
            TRYAGAIN:
            try
            {
                int no = Common.GetNumber("Enter the Number");
            }
            catch (FormatException)
            {
                Console.WriteLine("Input is not a valid Integer, Please try again");
                goto TRYAGAIN;
            }
            catch (OverflowException)
            {
                Console.WriteLine($"Integer value should be within the range of {int.MinValue} and {int.MaxValue}");
                goto TRYAGAIN;
            }
        }

        private static void usingTryCatchFinally()
        {
            try
            {
                throw new Exception("Simply raised to show an Example");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Close the code");
            }
        }
    }
}
