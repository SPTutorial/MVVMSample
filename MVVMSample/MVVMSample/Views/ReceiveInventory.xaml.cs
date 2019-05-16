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
	public partial class ReceiveInventory : ContentPage
	{
		public ReceiveInventory ()
		{
			InitializeComponent ();
		}

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}