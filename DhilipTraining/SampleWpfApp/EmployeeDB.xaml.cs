using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data;
using EmpComponent = DataAccessLib.EmployeeDB;//Alias to Ur employee db

namespace SampleWpfApp
{
    /// <summary>
    /// Interaction logic for EmployeeDB.xaml
    /// </summary>
    public partial class EmployeeDB : Window
    {
        public EmployeeDB()
        {
            InitializeComponent();
            lstNames.ItemsSource = Employees;
        }
        private List<string> getEmpnames()
        {
            EmpComponent db = new EmpComponent();
            var table = db.GetEmployees();
            List<string> names = new List<string>();
            foreach(DataRow row in table.Rows)
            {
                names.Add(row["EmpName"].ToString());
            }
            return names;
        }
        public List<string> Employees
        {
            get
            {
                return getEmpnames();
            }
        }

        private void onSelected(object sender, SelectionChangedEventArgs e)
        {
            var selectedName = lstNames.SelectedItem.ToString();
            var db = new EmpComponent();
            var data = db.GetEmployees();
            foreach(DataRow row in data.Rows)
            {
                if (row[1].ToString() == selectedName)
                {
                    txtId.Text = row[0].ToString();
                    txtName.Text = row[1].ToString();
                    txtAddress.Text = row[2].ToString();
                    txtSalary.Text = row[3].ToString();
                    return;//exit...
                }
            }
        }
    }
}
