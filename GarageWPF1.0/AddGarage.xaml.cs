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
    /// Interaction logic for AddGarage.xaml
    /// </summary>
    public partial class AddGarage : Window
    {

        GarageManager gMngr;

        public AddGarage(object gManager)
        {
            InitializeComponent();
            gMngr =  (GarageManager)gManager;
        }

        private void create_Click(object sender, RoutedEventArgs e)
        {
            //read & validate input from textbox1 & 2. Run createGarage when input is valid, else show warnings.
            
            if (validateInputs())
            {
                label.Content = "OK!";
                label2.Content = "OK!";

                int slotValue;

                Int32.TryParse(textBox2.Text, out slotValue);
                gMngr.CreateGarage(slotValue, textBox.Text);
                Close();
            }
            
        }

        private bool validateInputs()
        {
            //check textboxes

            if (textBox.Text.Length > 10 || textBox.Text.Length == 0)
            {
                warning1.Content = "!";
                return false;
            }

            int slotValue;

            Int32.TryParse(textBox2.Text, out slotValue);

            if (slotValue > 99 || slotValue == 0)
            {
                warning2.Content = "!";
                return false;
            }

            return true;
        }
    }
}
