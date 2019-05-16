using Rg.Plugins.Popup.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace MVVMSample.ViewModels
{
    public class AddEmployeePageViewModel : INotifyPropertyChanged
    {
        public INavigation Navigation { get; set; }
        public AddEmployeePageViewModel(INavigation navigation)
        {
            Navigation = navigation;
        }
        public Command ClosePopup
        {
            get
            {
                return new Command(() =>
                {
                    Navigation.PopPopupAsync();
                });
            }
        }
        public Command SaveEmployee
        {
            get
            {
                return new Command(() =>
                {
                    Data data = new Data();
                    data.Name = EmployeeName;
                    data.Address = Address;
                    MessagingCenter.Send<Data>(data, "ReceiveData");
                    Navigation.PopPopupAsync();
                });
            }
        }
        string _employeeName;
        public string EmployeeName
        {
            get { return _employeeName; }
            set
            {
                if (value != null)
                {
                    _employeeName = value;
                    OnPropertyChanged();
                }
            }
        }
        string _address;
        public string Address
        {
            get { return _address; }
            set
            {
                if(value!=null)
                {
                    _address = value;
                    OnPropertyChanged();
                }                
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
