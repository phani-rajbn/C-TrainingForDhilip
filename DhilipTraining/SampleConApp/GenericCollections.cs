using System;
using System.Collections.Generic;//Generic contain classes for generic collections...
using System.Linq;
/*
 * Why Collections?
 * Arrays are fixed in size, adding and removing is extremely difficult with it. 
 * Arrays store the data in one form only. U cannot have different business logic. Data structuring like Queue, Stack cannot be done with simple arrays. 
 * To get these features and more than this, we use collections. Since .NET 2.0, we have generic collections which are more type safe and powerfull. 
 * Lists, HashSet, Dictionary, Stack, Queue are some of the popular collection classes in Generics. 
 * All the collection classes do implement a set of interfaces which will give U all the functionalitites. So U can also create Ur own classes and implement those interfaces to create Custom Collection classes.
 * All Collection classes must and will implement IEnumerable<T> interface which helps in iterating the collection using foreach statement. If U want Ur class objects to be used in a foreach statement, then U should implement IEnumerable<T> in ur class. 
 */
namespace SampleConApp
{
    class GenericCollections
    {
        static void Main(string[] args)
        {
            //listExample();
            //hashSetExample();
            //DictionaryExample();
            //QueueExample();
            //StackExample();
        }

        private static void StackExample()
        {
            //Works on FILO manner:  First In, Last Out. Stack allows to add items to the top, and will remove items from the top only. 
            Stack<string> pages = new Stack<string>();
            pages.Push("Contacts");//Adds a new element into the Stack at the top...
            pages.Push("Phani");
            pages.Push("Dhilip");
            pages.Push("FlipKart");
            pages.Push("SamsungPage");
            pages.Pop();//Deletes the first element in the Stack. U cannot remove or add the element in b/w

            foreach (var item in pages) Console.WriteLine(item);
        }

        private static void QueueExample()
        {
            /*
             * Queue stores the data in the last, but u cannot add, remove any thing in b/w. 
             * Recently viewed items in Flipkart or Amazon will use this data structure
             */
            Queue<string> recentItems = new Queue<string>();
            do
            {
                Console.WriteLine("Enter the Item to view");
                if (recentItems.Count == 3)
                    recentItems.Dequeue();//Removes the first item from the Queue.
                recentItems.Enqueue(Console.ReadLine());//Adds the item to the bottom..
                Console.WriteLine("Ur recently viewed items:");
                var reversedData = recentItems.Reverse();
                foreach (var item in reversedData) Console.WriteLine(item);
            } while (true);
        }

        private static void DictionaryExample()
        {
            //Stores the data as key-value pairs. key is unique for the collection and the value associated with that key may not be unique for the collection. 
            Dictionary<string, string> users = new Dictionary<string, string>();
            users.Add("phani", "apple123");
            users.Add("Dhilip", "mango123");
            LABEL:
            string key = Common.GetString("Enter the key");
            if (users.ContainsKey(key))
            {
                Console.WriteLine("User already exists, please add anything else");
                goto LABEL;
            }
            string value = Common.GetString("Enter the value"); 
            users.Add(key, value);//Throws an Exception..

            foreach (var pair in users) Console.WriteLine($"Key: {pair.Key}\tValue : {pair.Value}");
        }

        private static void hashSetExample()
        {
            /*
             * Hashset stores only unique values. 
             * Every object created in CLR will generate an id called hashcode. 
             * The Hashset will use this hashcode to check whether it has elements of the same hashcode and then checks if it's equals method gives true or false.
             * If false, then object is added into the list, else it will not be added. 
             */
            HashSet<string> basket = new HashSet<string>();
            basket.Add("Apple");//Adds to the last of the list...
            basket.Add("Mango");
            basket.Add("Banana");
            basket.Add("Chikku");
            basket.Add("Chikku");//will not be added as the data already exists...
            basket.Add("Chikku");
            basket.Add("Chikku");
            Console.WriteLine("The no of fruits in the basket is "  + basket.Count);
        }

       private static void listExample()
       {
           /*
            * List is more like a dynamic array. It stores like an array, but will allow U to add, remove, insert or remove at specific index in ur code. 
            * List allows to add the data anywhere in ur data structure.
            */

            List<string> fruits = new List<string>();//blank list
            fruits.Add("Apple");//Adds to the last of the list...
            fruits.Add("Mango");
            fruits.Add("Banana");
            fruits.Add("Chikku");
            fruits.Insert(2, "Orange");//Will not replace, it just pushes itself into the location..
            foreach (var fruit in fruits) Console.WriteLine(fruit);
            Console.WriteLine("Enter the fruit to remove from the the list above");
            string fname = Console.ReadLine();
            var done = fruits.Remove(fname);//U can remove an element using its index also...
            if (done) Console.WriteLine("Fruit is removed");
            else Console.WriteLine("Fruit is not removed as it does not exist");
            foreach (var fruit in fruits) Console.WriteLine(fruit);
        }
    }
}
