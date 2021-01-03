using MvvmExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Points:
 * This example does not talk to the database.
 * This will only store the data in memory. If the app closes, the data is lost. 
 */
namespace MvvmExample.Data
{
    public class DataComponent
    {
        private List<Employee> employees = new List<Employee>();
        public DataComponent()
        {
            employees.Add(new Employee { EmpID = 111, EmpName = "Phaniraj", EmpAddress = "Bangalore", EmpSalary = 76000 });
            employees.Add(new Employee { EmpID = 112, EmpName = "Dhilip", EmpAddress = "Puducherry", EmpSalary = 66000 });
            employees.Add(new Employee { EmpID = 113, EmpName = "Gopal", EmpAddress = "Chennai", EmpSalary = 23000 });
            employees.Add(new Employee { EmpID = 114, EmpName = "Chinna", EmpAddress = "Nellore", EmpSalary = 78000 });
            employees.Add(new Employee { EmpID = 115, EmpName = "Naresh", EmpAddress = "Trichi", EmpSalary = 56000 });
        }
        public List<Employee> GetEmployees()
        {
            return employees;
        }

        //To Do: Create a function for deleting also...

        public void AddEmployee(Employee emp)
        {
            employees.Add(emp);
        }

        public void UpdateEmployee(Employee emp)
        {
            //foreach(var e in employees)
            //{
            //    if (e.EmpID == emp.EmpID)
            //        found = e;
            //}
            var found = employees.Find((e) => e.EmpID == emp.EmpID);
            found.EmpName = emp.EmpName;
            found.EmpAddress = emp.EmpAddress;
            found.EmpSalary = emp.EmpSalary;
        }
    }
}
