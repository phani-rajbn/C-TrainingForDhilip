using MvvmExample.Models;
using MvvmExample.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
namespace MvvmExample.ViewModel
{
    //If UR class and its properties have to be bound to the elements of WPF, Ur property should be a dependency Property. Dependency property will be available only in those classes that are derived from Dependency Object...
    //Dependency Property is that property which will evaluate the value of the property thro Bindings and other means instead of a simple set/get
    public class EmployeeVm :DependencyObject
    {
        public EmployeeVm()
        {
            var component = new DataComponent();
            Employees = component.GetEmployees();
        }
        public List<Employee> Employees
        {
            get { return (List<Employee>)GetValue(EmployeesProperty); }
            set { SetValue(EmployeesProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Employees.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty EmployeesProperty =
            DependencyProperty.Register("Employees", typeof(List<Employee>), typeof(EmployeeVm), new PropertyMetadata(null));
    }
}
