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
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();            
        }

        private void userNameComplete(object sender, EventArgs e)
        {
            pwd.Focus();
        }
        private void passwordComplete(object sender, EventArgs e)
        {
            loginBtn.Focus();
        }

        private void LoginBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ReceiveInventory());
        }
    }
}