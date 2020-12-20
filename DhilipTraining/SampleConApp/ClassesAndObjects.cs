using System;
using System.Collections.Generic;//Namespace for accesing Collection classes
namespace SampleConApp
{
    namespace OOPConcepts
    {
        class Employee//This class represents a real world employee
        {
            public int EmpID { get; set; }//Autmatic properties in C# since 4.0
            public string EmpName { get; set; }
            public string EmpAddress { get; set; }
            public DateTime EmpDateOfBirth { get; set; }
        }


        class EmpDatabase
        {
            private List<Employee> _empList = new List<Employee>();

            public void AddNewEmployee(Employee emp)
            {
                _empList.Add(emp);//List adds the element in it. Dynamic Array..
            }

            public void DeleteEmployee(int id)
            {
                for (int i = 0; i < _empList.Count; i++)
                {
                    if(_empList[i].EmpID == id)
                    {
                        _empList.RemoveAt(i);//Removes the element in that index...
                        return;//Exit the function...
                    }
                }
            }

            public void UpdateEmployeeDetails(Employee emp)
            {
                for (int i = 0; i < _empList.Count; i++)
                {
                    if(_empList[i].EmpID == emp.EmpID)
                    {
                        _empList[i].EmpName = emp.EmpName;
                        _empList[i].EmpAddress = emp.EmpAddress;
                        _empList[i].EmpDateOfBirth = emp.EmpDateOfBirth;
                        return;
                    }
                }
            }

            public List<Employee> Employees//Property with only get feature...
            {
                get
                {
                    return _empList;
                }
            }
        }
    }
   
    class ClassesAndObjects
    {
        static void Main(string[] args)
        {
            //OOPConcepts.Employee emp = new OOPConcepts.Employee();//U create an instance of a class in C#
            //emp.EmpID = 123;//U R using properties like fields...
            //emp.EmpName = "Phaniraj";
            //emp.EmpAddress = "Bangalore";
            //emp.EmpDateOfBirth = new DateTime(1976, 12, 01);

            //Taking inputs from the user..
            //emp.EmpID = Common.GetNumber("Enter the ID");
            //emp.EmpName = Common.GetString("Enter the Name");
            //emp.EmpAddress = Common.GetString("Enter the Address");
            //emp.EmpDateOfBirth = Common.GetDate();

            //Console.WriteLine($"The Name of the Employee is {emp.EmpName}");
            //Console.WriteLine("The Address of the Employee is " + emp.EmpAddress);
            //Console.WriteLine("The Date of Birth of the Employee is " + emp.EmpDateOfBirth.ToShortDateString());
            OOPConcepts.EmpDatabase db = new OOPConcepts.EmpDatabase();
            db.AddNewEmployee(new OOPConcepts.Employee { EmpID = 123, EmpAddress = "Pondicherry", EmpDateOfBirth = new DateTime(1990, 08, 01), EmpName = "Dhilip" });
            
            foreach(var emp in db.Employees)
                Console.WriteLine(emp.EmpName);
        }
    }
}
