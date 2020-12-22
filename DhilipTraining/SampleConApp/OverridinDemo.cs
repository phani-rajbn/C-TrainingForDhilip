using System;

/*
 * 2nd reason of Inheritance is to modify the existing/base class method funtionality.
 * This is called Method overriding. Base class has some functionality, Derived class will modify the functionality to suit its requirement. 
 * Overiding has 2 possibilities: Adding new feature to the function while retaining the old feature. Completly modifying the existing feature. 
 * Rules of implementing overriding:
 * Methods that U wish to override should have virtual keyword in their function declaration.
 * Methods that U override should be marked as override during implementation of the method in the derived class.
 * With method overriding, U can do runtime polymorphism. Polymorphism means one name different forms. 
 * However, If a method is not virtual and the derived class creates the same method, this Runtime polymorphism will not apply. In this case, the new method is not related to the old one and the derived class cannot use override keyword.
 */
namespace SampleConApp
{
    class BaseClass
    {
        public virtual void BaseFunc()
        {
            Console.WriteLine("Base class Function is implememted here");
        }

        public void MyFunc()
        {
            Console.WriteLine("MyFunction is implemented here only. Not expected to modify");
        }
    }
    //Modify the base class function...
    class DerivedClass : BaseClass
    {
        public override void BaseFunc()
        {
            //base.BaseFunc();//Will call the base version first...
            Console.WriteLine("Modified further with derived");
        }

        public void MyFunc()
        {
            Console.WriteLine("MyFunc is modified here forcefully");
        }
    }

    class OverridingDemo
    {
        static void Main()
        {
            BaseClass cl = new BaseClass();
            cl.BaseFunc();
            cl.MyFunc();
            cl = new DerivedClass();//A base class variable can be instantiated to any of its derived classes. 
            cl.BaseFunc();
            cl.MyFunc();

            DerivedClass dl = new DerivedClass();
            dl.MyFunc();
        }
    }
}
