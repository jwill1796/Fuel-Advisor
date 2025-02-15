using fuel_advisor_maui.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace fuel_advisor_maui.ViewModels
{
    class MainPageViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Vehicles> Vehicles { get; set; }
        public MainPageViewModel()
        {
            Vehicles = new ObservableCollection<Vehicles>
            {
                new Vehicles { Make = "Toyota", Model = "Corolla", Year = "2021", FuelType = "Gasoline", FuelEconomy = "30 MPG" },
                new Vehicles { Make = "Toyota", Model = "Prius", Year = "2021", FuelType = "Hybrid", FuelEconomy = "50 MPG" },
                new Vehicles { Make = "Ford", Model = "F-150", Year = "2021", FuelType = "Gasoline", FuelEconomy = "20 MPG" },
                new Vehicles { Make = "Chevrolet", Model = "", Year = "2021", FuelType = "Electric", FuelEconomy = "3.9 mi/kWh" }
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
