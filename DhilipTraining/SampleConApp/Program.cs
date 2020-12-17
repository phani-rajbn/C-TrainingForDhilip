using System;
/*
 * How to create a C# project
 * How to add a new file to a project
 * How to add existing file to a project.
 * How to see the File location in ur Project. 
 * How to add new project to the current soln.
 * How to add existing project to the current soln. 
 * How to remove/add things into the project and soln. 
 * How to customize ur IDE. 
 */
namespace SampleConApp
{
    class MyFirstProgram
    {
        static void takeInputsAndDisplay()//camel casing for private members of the class..
        {
            Console.WriteLine("Enter UR Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter UR Address");
            string address = Console.ReadLine();
            Console.WriteLine("Enter UR Phone");
            long phone = long.Parse(Console.ReadLine());//Converting string to long...
            //Console.WriteLine($"Decimal will hold values ranging from {decimal.MinValue} and {decimal.MaxValue}");
            //Display the inputs:
            Console.WriteLine($"The Name entered is {name} from {address}.\nHe is available at {phone}");
            
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello world!!!");
            //Console.WriteLine("This is another line");
            //Console.Write("This will be in the same line");
            //Console.Write(" Same line code");
            //var is implicit typed variable whre the variable will take the data type to which to which it is assigned.
            //Console.WriteLine("Enter UR Name");
            //string name = Console.ReadLine();
            //Console.WriteLine("The name is " + input);//very old syntax, not recommended...
            //Console.WriteLine("The name entered is {0}", input);//Formating syntax...
            //Console.WriteLine($"The name entered is {input}");//New syntax of C# 5.0

            //Call the method U have created above...
            takeInputsAndDisplay();
        }
    }
}