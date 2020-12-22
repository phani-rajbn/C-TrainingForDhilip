using System;

/*
 * Based on Open-Closed Principle of the SOLID Priciples. 
 * A Class is designed for extension but is closed for modification. 
 * Once the class is created, it is expected to be untouched. Any changes U make should be done by extending the class and modify it there rather than modifying it in the class itself. 
 * A class is closed for modification but is open for Extension. This extension feature is called as Inheritance in OOP. 
 * The class that is being extended is called as Base/Super/Parent class. The class that extends the functionality is called as Derived/Child class.
 * U can have only one base class at any level. This is called Single Inheritance that is supported in C# and Java. 
 * However, U can use multi level inheritance. A->B->C. Here C has both the features of A and B.
 * Why? 2 Possibilities: Add new functions, Modify Existing functions
 * WinForms will have a class called System.Windows.Form. U create a new form by inheriting UR Form from System.Windows.Form and will automatically get all the features of the Form. Later U extend it with UR own controls and Functionalities. 
 * Only protected, internal and public members of the base class can be used in the derived class. 
 */
namespace SampleConApp
{
    class BaseClass
    {
        public void BaseFunc()
        {
            Console.WriteLine("Base class Function is implememted here");
        }
    }

    //2 Possibilities: Add new functions, Modify Existing functions. 
    class DerivedClass : BaseClass //Syntax for inheritance
    {
        //This class will retain all the features of the base class. However, it can add its own features for extension. 
        public void DerivedFunc() 
        {
            Console.WriteLine("Derived class function is implemented here");
        }
    }
    class InheritanceDemo
    {
        static void Main(string[] args)
        {
            BaseClass bCl = new BaseClass();//It allocates the memory for Ur object in heap. "Stack vs Heap in Programming" 
            bCl.BaseFunc();

            DerivedClass dCl = new DerivedClass();//Syntax of creating the new instance of the class. 
            dCl.BaseFunc();//Base class function
            dCl.DerivedFunc();//Its own class function. 
            
        }
    }
}
