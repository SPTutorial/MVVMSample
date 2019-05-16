using MVVMSample.Models;
using MVVMSample.Views;
using Rg.Plugins.Popup.Extensions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace MVVMSample.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        ObservableCollection<Employee> AllEmployeeData;
        public INavigation Navigation { get; set; }
        public MainPageViewModel(INavigation navigation)
        {
            Navigation = navigation;


            EmployeeList = new ObservableCollection<Employee>();

            AllEmployeeData = new ObservableCollection<Employee>();

            AllEmployeeData.Add(new Employee { Name = "S.K Yadav", Address = "23 GD Road" });
            AllEmployeeData.Add(new Employee { Name = "SM Singh", Address = "96 MC garden Road" });
            AllEmployeeData.Add(new Employee { Name = "Rajib Das", Address = "23 L N Sarani" });
            AllEmployeeData.Add(new Employee { Name = "SK Mitra", Address = "34 Lake Town" });

            EmployeeList = AllEmployeeData;
        }
        
        public Command SearchData
        {
            get
            {
                return new Command(() =>
                {
                    if(!string.IsNullOrEmpty(SearchText))
                    {
                        List<Employee> searchData = AllEmployeeData.Where(x => x.Name.ToLower().Contains(SearchText.ToLower())).ToList();
                        EmployeeList = new ObservableCollection<Employee>(searchData as List<Employee>);
                        if(EmployeeList.Count() == 0)
                        {
                            IsVisibleStatus = true;
                        }
                        else
                        {
                            IsVisibleStatus = false;
                        }
                    }
                    else
                    {
                        EmployeeList = AllEmployeeData;
                        IsVisibleStatus = false;
                    }
                });
            }
        }
        public Command SearchBtnPress
        {
            get
            {
                return new Command(() =>
                {
                    if (!string.IsNullOrEmpty(SearchText))
                    {
                        List<Employee> searchData = AllEmployeeData.Where(x => x.Name.ToLower().Contains(SearchText.ToLower())).ToList();
                        EmployeeList = new ObservableCollection<Employee>(searchData as List<Employee>);
                        if (EmployeeList.Count() == 0)
                        {
                            IsVisibleStatus = true;
                        }
                        else
                        {
                            IsVisibleStatus = false;
                        }
                    }
                    else
                    {
                        EmployeeList = AllEmployeeData;
                        IsVisibleStatus = false;
                    }
                });
            }
        }
        public Command AddEmployee
        {
            get
            {
                return new Command(() =>
                {
                    Navigation.PushPopupAsync(new AddEmployeePage());
                    MessagingCenter.Unsubscribe<Data>(this, "ReceiveData");
                    MessagingCenter.Subscribe<Data>(this, "ReceiveData", (value) =>
                    {
                        EmployeeList.Add(new Employee { Name = value.Name, Address = value.Address });
                        MessagingCenter.Unsubscribe<Data>(this, "ReceiveData");
                    });
                });
            }
        }
        string _searchText;
        public string SearchText
        {
            get { return _searchText; }
            set
            {
                if (value != null)
                {
                    _searchText = value;
                    OnPropertyChanged();
                }
            }
        }
        bool _isVisibleStatus;
        public bool IsVisibleStatus
        {
            get { return _isVisibleStatus; }
            set
            {
                _isVisibleStatus = value;
                OnPropertyChanged();
            }
        }
        #region Exreas

        private bool _isLogedIn;

        public bool IsLogedIn
        {
            get { return _isLogedIn; }
            set { _isLogedIn = value; }
        }
        #endregion
        ObservableCollection<Employee> _employeeList;
        public ObservableCollection<Employee> EmployeeList
        {
            get { return _employeeList; }
            set
            {
                _employeeList = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
    public class Data
    {
        public string Name { get; set; }
        public string Address { get; set; }
    }
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
   
}
