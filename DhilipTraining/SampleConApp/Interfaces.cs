using System;
/*
 * Interfaces are like abstract classes that are used to have a set of fns to be implemented by a class. 
 * Interfaces will not have any form of implementation. However since C# 7, we have default methods which allow interfaces to implement methods.
 * Abstract classes can have normal and virtual methods but interfaces cannot have these. 
 * U can implement multiple interfaces at the same level, which U cannot do it with abstract classes. 
 * interfaces cannot have non public methods, so there is no access specifier in interfaces. 
 * When a class implements an interface, it must implement all the methods of the interface as public only.
 * It is suggested to create the interface first, get it approved and then start implementing the interface.
 * Implicit implementation vs. Explicit Implementation in interfaces.(Exercise for U).
 */
namespace SampleConApp
{
    interface IExample
    {
        void ExampleFunc();
    }
    interface ISimple
    {
        void SimpleFunc();
    }

    class SimpleExample :  IExample, ISimple
    {
        int data;
        public void ExampleFunc()
        {
            data = 123;
            Console.WriteLine("Example Func implemented");
        }

        public void SimpleFunc()
        {
            Console.WriteLine("The value set is " + data);
            Console.WriteLine("Simple Func implemented");
        }
    }
    class Interfaces
    {
        static void Main(string[] args)
        {
            //SimpleExample simEx = new SimpleExample();
            //simEx.SimpleFunc();
            //simEx.ExampleFunc();

            //using Runtime polmorphism..
            IExample ex = new SimpleExample();
            ex.ExampleFunc();

            //ISimple sim = new SimpleExample();
            ISimple sim = (ISimple)ex;//UR object will be now behave like ISimple so that it retains the data U have set using the IExample object. In other words, U share the same object in the form of sim.
            sim.SimpleFunc();
        }
    }
}
