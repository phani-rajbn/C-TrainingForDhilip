using System;
/*
 * Abstract class is one that has one or more abstract methods in them. 
 * Abstract methods are one that dont have implementation but simply a declaration, this is intended to be implemented by the derived classes. 
 * Abstract classes are not complete, so U cannot instantiate the abstract class. Ofcourse, U can create a variable of the abstract class but instantiate it to the derived class.
 * Abstract classes can have normal methods and virtual methods in them.
 */
namespace SampleConApp
{
    //A class which has methods that are not implemented but declared only. These methods however, will be implemented by their derived classes.

    abstract class Account
    {
        public int AccountNo { get; set; }
        public string Name { get; set; }
        public int Balance { get; private set; }


        //Constructor.
        public Account(int amount = 5000)
        {
            Balance = amount;
        }

        public void Credit(int money)
        {
            Balance += money;
        }

        public void Debit(int money)
        {
            if (Balance < money) throw new Exception("Insufficient funds");
            Balance -= money;
        }
        public abstract void CalculateInterest();//abstract methods will not have implementation..
    }

    class SBAccount : Account
    {
        //When U create a constructor for the derived class, U must call the base class constructor using base keyword. 
        public SBAccount(int amount) : base(amount)
        {

        }
        //override is applicable for methods of the base class that are marked: virtual, override, abstract.
        public override void CalculateInterest()
        {
            int principal = base.Balance;
            double rate = 6.5 / 100;
            double term = 1 / 4;
            double interest = principal * rate * term;
            base.Credit((int)interest);
        }
    }
    class AbstractClass
    {
        static void Main(string[] args)
        {
            Account acc = new SBAccount(15000) { AccountNo = 11111, Name = "Dhilip" };
            Console.WriteLine("The Balance is " + acc.Balance);
        }
    }
}
