using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

//This example shows how to create Custom Commands and Use in our application...
namespace SampleWpfApp.Infrastructure
{
    public static class MyCommands
    {
        private static RoutedUICommand _saveAs;

        static MyCommands()
        {
            InputGestureCollection collection = new InputGestureCollection();
            collection.Add(new KeyGesture(Key.B, ModifierKeys.Control, "Ctrl+B"));
            _saveAs = new RoutedUICommand("Save As", "SaveAs", typeof(MyCommands), collection);
        }

        public static RoutedUICommand SaveAs
        {
            get { return _saveAs; }
        }
    }
}
