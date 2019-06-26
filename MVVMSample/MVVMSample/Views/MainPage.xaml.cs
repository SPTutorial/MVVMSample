using MVVMSample.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MVVMSample
{
    public partial class MainPage : ContentPage
    {
        ObservableCollection<Employee> AllEmployeeData;
        ObservableCollection<Employee> searchData=new ObservableCollection<Employee>();
        public MainPage()
        {
            InitializeComponent();
             BindingContext = new MainPageViewModel(Navigation);

            //AllEmployeeData = new ObservableCollection<Employee>();
            //AllEmployeeData.Add(new Employee { Name = "S.K Yadav", Address = "23 GD Road" });
            //AllEmployeeData.Add(new Employee { Name = "SM Singh", Address = "96 MC garden Road" });
            //AllEmployeeData.Add(new Employee { Name = "Rajib Das", Address = "23 L N Sarani" });
            //AllEmployeeData.Add(new Employee { Name = "SK Mitra", Address = "34 Lake Town" });

            //listView.ItemsSource = AllEmployeeData;
            //status.IsVisible = false;
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            //if(!string.IsNullOrEmpty( e.NewTextValue))
            //{
            //    List<Employee> data = AllEmployeeData.Where(x => x.Name.ToLower().Contains(e.NewTextValue.ToLower())).ToList();
            //    searchData = new ObservableCollection<Employee>(data as List<Employee>);

            //    listView.ItemsSource = searchData;

            //    if (searchData.Count() == 0)
            //    {
            //        status.IsVisible = true;
            //    }
            //    else
            //    {
            //        status.IsVisible = false;
            //    }
            //}
            //else
            //{
            //    listView.ItemsSource = AllEmployeeData;
            //}
        }

        private void SearchBar_SearchButtonPressed(object sender, EventArgs e)
        {
            //if (!string.IsNullOrEmpty(searchBar.Text))
            //{
            //    List<Employee> data = AllEmployeeData.Where(x => x.Name.ToLower().Contains(searchBar.Text.ToLower())).ToList();
            //    searchData = new ObservableCollection<Employee>(data as List<Employee>);

            //    listView.ItemsSource = searchData;

            //    if (searchData.Count() == 0)
            //    {
            //        status.IsVisible = true;
            //    }
            //    else
            //    {
            //        status.IsVisible = false;
            //    }
            //}
            //else
            //{
            //    listView.ItemsSource = AllEmployeeData;
            //}
        }
    }
}
