using System;


namespace SampleConApp
{
    //Too many things are done by the Main function. 
    //Seperation of Concerns: One method should do only one job.
    //static is required for those members where U dont want to create object of the class to call them. For frequently used functions in ur program it is good to make the function as static, so there will no burden of object creation and its destruction. 
    class ExampleCalcProgram
    {
        static double getValue(string question)
        {
            Console.WriteLine(question);
            double value = double.Parse(Console.ReadLine());
            return value;
        }
        static char getOperand(string question)
        {
            Console.WriteLine(question);
            char value = char.Parse(Console.ReadLine());
            return value;
        }

        static double performOperation(double fValue, double sValue, char operand)
        {
            double result = 0;//C# expects to initialize the local variables before U use them.
            switch (operand)
            {
                case '+':
                    result = fValue + sValue;
                    break;
                case '-':
                    result = fValue - sValue;
                    break;
                case 'X':
                    result = fValue * sValue;
                    break;
                case '/':
                    result = fValue / sValue;
                    break;
                default:
                    result = 0;
                    break;
            }
            return result;
        }
        static void Main()
        {
            bool repeat = false;
            do
            {
                double fValue = getValue("Enter the First Value");
                double sValue = getValue("Enter the Second Value");

                char chOperand = getOperand("Enter the Operation: +, -, X or /");

                double result = performOperation(fValue, sValue, chOperand);

                Console.WriteLine($"The result of this operation is {result}");

                Console.WriteLine("Press X to exit");
                string value = Console.ReadLine();
                if (value.ToUpper() != "X") repeat = true;
                Console.Clear();
            } while (repeat);
        }
    }
}

//Create a calculator program to do data calculations based on Area. Functions to convert feet to yards, feet to mtrs
//Create a program to take inputs from the user and return the Simple interest of the amount. Calculate the RD amount. 

