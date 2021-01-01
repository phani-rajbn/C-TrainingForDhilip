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
using System.IO;
using System.Windows.Forms;

namespace SampleWpfApp
{
    /// <summary>
    /// Interaction logic for NotepadExample.xaml
    /// </summary>
    public partial class NotepadExample : Window
    {
        static string fileName = string.Empty;
        public NotepadExample()
        {
            InitializeComponent();
        }

        private void onNew(object sender, RoutedEventArgs e)
        {
            txtContent.Text = string.Empty;
            fileName = string.Empty;
        }

        private void onOpen(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.ShowDialog();
            fileName = dlg.FileName;
            if (string.IsNullOrEmpty(fileName))
            {
                System.Windows.MessageBox.Show("No file was selected to Open");
                return;//Exit the function...
            }
            txtContent.Text = File.ReadAllText(fileName);
        }

        private void onFont(object sender, RoutedEventArgs e)
        {
            FontDialog dlg = new FontDialog();
            dlg.ShowDialog();
            txtContent.FontSize = dlg.Font.Size;
            txtContent.FontFamily = new FontFamily(dlg.Font.Name);
        }

        private void onPalette(object sender, RoutedEventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.ShowDialog();
            Color color = Color.FromRgb(dlg.Color.R, dlg.Color.G, dlg.Color.B);
        }

        private void onSave(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                SaveFileDialog dlg = new SaveFileDialog();
                dlg.ShowDialog();
                fileName = dlg.FileName;
                if (string.IsNullOrEmpty(fileName))
                {
                    System.Windows.MessageBox.Show("User has cancelled the Saving option");
                    return;
                }
            }
            File.WriteAllText(fileName, txtContent.Text);
        }

        private void onSaveAs(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.ShowDialog();
            fileName = dlg.FileName;
            if (string.IsNullOrEmpty(fileName))
            {
                System.Windows.MessageBox.Show("User has cancelled the Saving option");
                return;
            }
            File.WriteAllText(fileName, txtContent.Text);
        }
    }
}
