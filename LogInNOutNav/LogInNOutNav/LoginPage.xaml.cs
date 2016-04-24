using System;
using Xamarin.Forms;

namespace LogInNOutNav
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        public void OnLoginClicked(object sender, EventArgs args)
        {
            App.IsLoggedIn = true;
            var vHomePage = new HomePage();
            Navigation.InsertPageBefore(vHomePage, this);
            Navigation.PopAsync();
        }
    }
}
