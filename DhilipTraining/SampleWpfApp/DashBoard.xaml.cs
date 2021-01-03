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
    /// Interaction logic for DashBoard.xaml
    /// </summary>
    public partial class DashBoard : Window
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MainWindow win = new MainWindow();
            win.ShowDialog();//Displays the WIndow as Modal. It will not shift the focus to the Main Window until U close the current Window..
        }

        private void onGridClick(object sender, RoutedEventArgs e)
        {
            GridPanel panel = new GridPanel();
            panel.ShowDialog();
        }

        private void onTextWindow(object sender, RoutedEventArgs e)
        {
            NotepadExample win = new NotepadExample();
            win.ShowDialog();
        }

        private void onEventWindow(object sender, RoutedEventArgs e)
        {
            ElementBinidng win = new ElementBinidng();
            win.ShowDialog();
        }

        private void onResource(object sender, RoutedEventArgs e)
        {
            Resources win = new Resources();
            win.ShowDialog();
        }//Show(Modaless) vs ShowDialog(Modal)..

        private void OnStyles(object sender, RoutedEventArgs e)
        {
            Styles win = new Styles();
            win.ShowDialog();
        }

        private void onTrigger(object sender, RoutedEventArgs e)
        {
            TriggersExample win = new TriggersExample();
            win.ShowDialog();
        }
    }
}
