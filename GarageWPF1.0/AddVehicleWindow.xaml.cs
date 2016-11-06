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

namespace GarageWPF1._0
{
    /// <summary>
    /// Interaction logic for AddVehicleWindow.xaml
    /// </summary>
    public partial class AddVehicleWindow : Window
    {

        GarageManager gMngr;

        public AddVehicleWindow(object gManager)
        {
            InitializeComponent();
            gMngr = (GarageManager)gManager;

            var elements = new List<UIElement> {regnrTxt, wheelsTxt, colorTxt};

            addEventListeners(elements);
        }

        private void addEventListeners(List<UIElement> elements)
        {
            foreach (var element in elements)
            {
                element.GotKeyboardFocus += focusEvent;
                element.PreviewMouseLeftButtonDown += focusEvent2;
            }
        }

        private void focusEvent2(object sender, MouseButtonEventArgs e)
        {
            DependencyObject parent = e.OriginalSource as UIElement;
            while (parent != null && !(parent is TextBox))
                parent = VisualTreeHelper.GetParent(parent);

            if (parent != null)
            {
                var textBox = (TextBox)parent;
                if (!textBox.IsKeyboardFocusWithin)
                {
                    textBox.Focus();
                    e.Handled = true;
                }
            }
        }

        private void focusEvent(object sender, RoutedEventArgs e)
        {
            var textBox = e.OriginalSource as TextBox;
            if (textBox != null)
                textBox.SelectAll();
        }

        private void create_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
