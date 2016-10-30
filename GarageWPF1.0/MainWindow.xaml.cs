using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace GarageWPF1._0
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        GarageManager gMngr = new GarageManager();
        UIManager uiMngr = new UIManager();
        ObservableCollection<Vehicle> listCurrent;
        ObservableCollection<Vehicle> listPrevious;

        public MainWindow()
        {
            InitializeComponent();
            setDataContexts();
        }

        private void LoadGarage()
        {
            gMngr.CreateExampleGarage();
            uiMngr.garageLoaded = true;
            listCurrent = new ObservableCollection<Vehicle>(gMngr.GetAll(0));
            icTodoList.ItemsSource = listCurrent;
        }

        private void setDataContexts()
        {
            rect1.DataContext = uiMngr;
            rect2.DataContext = uiMngr;
        }

        private void loadBtn_Click(object sender, RoutedEventArgs e)
        {
            LoadGarage();
            
        }

        private void sortVehicleBtn_Click(object sender, RoutedEventArgs e)
        {
            if (listCurrent != null)
            {
                listPrevious = new ObservableCollection<Vehicle>(listCurrent);

                if (uiMngr.vehicleOrderDesc) {
                    listCurrent = gMngr.SortBy("name", listCurrent);
                    uiMngr.vehicleOrderDesc = false;
                }
                else {
                    listCurrent = gMngr.SortByDesc("name", listCurrent);
                    uiMngr.vehicleOrderDesc = true;
                }
                
                icTodoList.ItemsSource = listCurrent;
            }
        }

        private void sortRegBtn_Click(object sender, RoutedEventArgs e)
        {
            if (listCurrent != null)
            {
                listPrevious = new ObservableCollection<Vehicle>(listCurrent);

                if (uiMngr.regOrderDesc)
                {
                    listCurrent = gMngr.SortBy("regnr", listCurrent);
                    uiMngr.regOrderDesc = false;
                }
                else
                {
                    listCurrent = gMngr.SortByDesc("regnr", listCurrent);
                    uiMngr.regOrderDesc = true;
                }

                icTodoList.ItemsSource = listCurrent;
            }
        }

        private void sortWheelsBtn_Click(object sender, RoutedEventArgs e)
        {
            if (listCurrent != null)
            {
                listPrevious = new ObservableCollection<Vehicle>(listCurrent);

                if (uiMngr.wheelsOrderDesc)
                {
                    listCurrent = gMngr.SortBy("wheels", listCurrent);
                    uiMngr.wheelsOrderDesc = false;
                }
                else
                {
                    listCurrent = gMngr.SortByDesc("wheels", listCurrent);
                    uiMngr.wheelsOrderDesc = true;
                }

                icTodoList.ItemsSource = listCurrent;
            }
        }

        private void sortColorBtn_Click(object sender, RoutedEventArgs e)
        {
            if (listCurrent != null)
            {
                listPrevious = new ObservableCollection<Vehicle>(listCurrent);

                if (uiMngr.colorOrderDesc)
                {
                    listCurrent = gMngr.SortBy("color", listCurrent);
                    uiMngr.colorOrderDesc = false;
                }
                else
                {
                    listCurrent = gMngr.SortByDesc("color", listCurrent);
                    uiMngr.colorOrderDesc = true;
                }

                icTodoList.ItemsSource = listCurrent;
            }
        }

        private void newVehBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
