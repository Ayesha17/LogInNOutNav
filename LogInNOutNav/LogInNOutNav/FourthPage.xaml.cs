using System;
using Xamarin.Forms;

namespace LogInNOutNav
{
    public partial class FourthPage : ContentPage
    {
        public FourthPage()
        {
            InitializeComponent();
        }
        public void OnLogOut(object sender, EventArgs args)
        {
            App.IsLoggedIn = false;
            Navigation.PopToRootAsync();
        }
        public void OnHome(object sender, EventArgs args)
        {
            Navigation.PopToRootAsync();
        }
        public void OnFirst(object sender, EventArgs args)
        {
            Navigation.PushAsync(new FirstPage());            
        }
    }
}
