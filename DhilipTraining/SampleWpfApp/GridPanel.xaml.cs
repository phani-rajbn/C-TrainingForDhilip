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

namespace SampleWpfApp
{
    /// <summary>
    /// Interaction logic for GridPanel.xaml
    /// </summary>
    public partial class GridPanel : Window
    {
        public GridPanel()
        {
            InitializeComponent();
        }

        private void onSave(object sender, RoutedEventArgs e)
        {
            //Take input values.
            var id = int.Parse(txtId.Text);
            var name = txtName.Text;
            var address = txtAddress.Text;
            var phone = long.Parse(txtPhone.Text);
            //Make it a string
            var details = $"{name} from {address} has registered with Us. \nHe Will be available on {phone}. His ID for further reference is {id}";
            //Place it in the label.
            lblDisplay.Content = details;
        }

        private void onCancel(object sender, RoutedEventArgs e)
        {
            //Clear all the text of the txtBoxes..
            txtId.Text = string.Empty;
            txtName.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtPhone.Text = string.Empty;
            lblDisplay.Content = string.Empty;
        }
    }
}
