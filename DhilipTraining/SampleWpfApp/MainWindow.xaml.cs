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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SampleWpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //This function is called when the user clicks the button...
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //get the values entered in the text boxes...
            var name = txtName.Text;
            var address = txtAddress.Text;
            var phone = txtPhone.Text;
            var content = $"The name is {name} from {address}. He can be contacted on {phone}";
            MessageBox.Show(content);
        }
    }
}
