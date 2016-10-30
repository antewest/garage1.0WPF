using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace GarageWPF1._0
{
    internal class UIManager : INotifyPropertyChanged
    {
        private bool gLoaded;
        private bool vSelected;

        public bool garageLoaded {
            get { return this.gLoaded; }
            set
            {
                if (this.gLoaded != value)
                {
                    this.gLoaded = value;
                    this.NotifyPropertyChanged("garageLoaded");
                }
            }
        }
        public bool vehicleSelected {
            get { return this.vSelected; }
            set
            {
                if (this.vSelected != value)
                {
                    this.vSelected = value;
                    this.NotifyPropertyChanged("vehicleSelected");
                }
            }
        }

        public bool vehicleOrderDesc { get; set; }
        public bool regOrderDesc { get; set; }
        public bool wheelsOrderDesc { get; set; }
        public bool colorOrderDesc { get; set; }

        public UIManager()
        {
            garageLoaded = false;
            vehicleSelected = false;

            vehicleOrderDesc = true;
            regOrderDesc = true;
            wheelsOrderDesc = true;
            colorOrderDesc = true;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}