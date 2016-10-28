using DataBindingDemo.Model;
using GalaSoft.MvvmLight;
using Microsoft.Practices.ServiceLocation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBindingDemo.ViewModel
{
    public class MainPageViewModel: ViewModelBase
    {
        private Coord data;
        private ObservableCollection<Coord> list = new ObservableCollection<Coord>();
        private bool _isLoading = false;
        public bool IsLoading
        {
            get { return _isLoading; }
            set { _isLoading = value;
                RaisePropertyChanged("IsLoading");
            }
        }
        public ObservableCollection<Coord> List
        {
            get { return list; }
            set
            {
                if (value != list)
                    list = value;
                RaisePropertyChanged("List");
            }
        }
        public string Title
        {
            get { return data.title; }
            set { if (value != data.title)
                    data.title = value;
                RaisePropertyChanged("Title");
            }
        }
        public double Lat
        {
            get { return data.lat; }
            set
            {
                if (value != data.lat)
                    data.lat = value;
                RaisePropertyChanged("Lat");
            }
        }
        public double Lon
        {
            get { return data.lon; }
            set
            {
                if (value != data.lon)
                    data.lon = value;
                RaisePropertyChanged("Lon");
            }
        }
        public void add()
        {
            list.Add(new Coord() { lat = 42342, title = "lalala", lon = 423423 });
        }
        public MainPageViewModel()
        {
            list.Add(new Coord() { lat=42342, title="lalala", lon=423423 });
            list.Add(new Coord() { lat = 4234212, title = "lalala2", lon = 4234232 });
            list.Add(new Coord() { lat = 423412, title = "lalala3", lon = 4234232 });
        }
       
    }
}
