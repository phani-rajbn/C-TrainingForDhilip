using System;

/*
 * Arrays are reference types. They are created in the heap area managed by garbage collector(GC).
 * GC is a component of CLR that manages the memory of Ur application. It ensures that U R not out of memory.
 * Arrays are fixed in size in C#. If U want dynamic array U should use collections Framework.
 * Arrays are the most perfomance oriented data structure. 
 * If U know the size and the datatype of the collection, U should go for array. 
 * U can also create multi dimensional array and Jagged Arrays in C#.
 * Jagged Arrays are array of arrays. here U will have fixed no or rows but variable no of columns. A School is an array of classrooms where each room has variable no of students in it...
 * Arrays are instances of a .NET Class called System.Array. 
 * Array class will give methods and properties to work with that array object. 
 */
namespace SampleConApp
{
    struct Employee//User defined data type..
    {
        public int EmpID;
        public string EmpName;
        public string EmpAddress;
    }
    class ArraysExample
    {
        static void Main(string[] args)
        {
            //firstExample();;ppppp
            //otherSyntax();
            //UserDefinedArrayExample();
            //multiDimensionalArray();
            //jaggedArrayExample();
            //usingArrayClass();
            //How to create an array of unknown data type and unknown size at compile time in C#.
        }

        private static void usingArrayClass()
        {
            Console.WriteLine("Enter the no of elements U want to create in the array");
            int size = int.Parse(Console.ReadLine());
            var elements = Array.CreateInstance(typeof(int), size);
            for(var index = 0; index < size;index++)
            {
                Console.WriteLine($"Enter a number to the index {index}");
                int value = int.Parse(Console.ReadLine());
                elements.SetValue(value, index);
            }

            foreach (var element in elements) Console.WriteLine(element);
        }

        private static void jaggedArrayExample()
        {
            int[][] school = new int[4][];//Rows are 4 in no.....
            school[0] = new int[] { 56, 67, 66, 56, 67 };
            school[1] = new int[] { 66, 56, 67 };
            school[2] = new int[] { 56, 67, 66, 56, 67, 77, 66, 54 };
            school[3] = new int[] { 56, 67, 66, 56 };
            //Display the array in matrix format:
            for (int i = 0; i < school.Length; i++)
            {
                foreach(var marks in school[i])
                    Console.Write(marks + " ");
                Console.WriteLine();
            }
        }

        private static void multiDimensionalArray()
        {
            int[,] marks = new int[,] { { 45, 56, 67 }, { 76, 87, 66 }, { 89, 90, 87 }, { 66, 56, 45 }, { 89, 56, 21 } };//3x3 structure..
            Console.WriteLine($"The no of dimensions: {marks.Rank}");
            Console.WriteLine($"The length of the 1st demension: {marks.GetLength(0)}");
            Console.WriteLine($"The length of the 2nd demension: {marks.GetLength(1)}");

            for (var i = 0; i < marks.GetLength(0); i++)
            {
                for (var j = 0; j < marks.GetLength(1); j++)
                {
                    Console.Write(marks[i, j] + " ");
                }
                Console.WriteLine();//Move to the next line
            }
        }

        private static void otherSyntax()
        {
            int[] values = { 23, 45, 54, 75, 42, 34 };//There is no need to mention the size or new operator...
            foreach (var value in values) Console.WriteLine(value);
        }

        private static void UserDefinedArrayExample()
        {
            Employee[] employees = new Employee[5];//U can take input from the user and set the size...
            employees[0] = new Employee { EmpID = 123, EmpAddress = "Bangalore", EmpName = "Phaniraj" };
            employees[1] = new Employee { EmpID = 124, EmpAddress = "Pondicherry", EmpName = "Dhilip" };
            employees[2] = new Employee { EmpID = 125, EmpAddress = "Trichy", EmpName = "Gopal" };
            employees[3] = new Employee { EmpID = 126, EmpAddress = "Mysore", EmpName = "Venkatesh" };
            employees[4] = new Employee { EmpID = 127, EmpAddress = "Chennai", EmpName = "Suman" };
            //Length property of the Array will give U the no of the elements in the array..
            for (var i = 0; i < employees.Length; i++)
            {
                Console.WriteLine($"{employees[i].EmpName} is from {employees[i].EmpAddress}");
            }
        }

        private static void firstExample()
        {
            //datatype identifier = new datatype[size];
            //datatype identifier = {....values seperated by comma.....};
            string[] fruits = new string[5];//Syntax 
            fruits[0] = "Apple";//accessing individual elements.
            fruits[1] = "Orange";
            fruits[2] = "Banana";
            fruits[3] = "Lime";
            fruits[4] = "Chikku";
            //foreach is used for iteration of items in the collection.
            foreach (var fruit in fruits) Console.WriteLine(fruit);
        }
    }
}
