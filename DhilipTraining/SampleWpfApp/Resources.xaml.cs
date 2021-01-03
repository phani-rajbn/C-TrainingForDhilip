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
    /// Interaction logic for Resources.xaml
    /// </summary>
    public partial class Resources : Window
    {
        public Resources()
        {
            InitializeComponent();
        }
        //There are 2 events for Windows while it closes: Closing(Pre) and Closed(Post)
        private void onClose(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var res = MessageBox.Show("Do U want to really close?", "Title", MessageBoxButton.YesNo);
            if (res == MessageBoxResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }
    }
}
