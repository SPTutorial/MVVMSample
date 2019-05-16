using MVVMSample.ViewModels;
using Rg.Plugins.Popup.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVMSample.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AddEmployeePage : PopupPage
	{
		public AddEmployeePage ()
		{
			InitializeComponent ();
            BindingContext = new AddEmployeePageViewModel(Navigation);

        }
        protected override bool OnBackButtonPressed()
        {
            // if you dont want to close the popup on hardware backbutton
            return  true;
        }
    }
}