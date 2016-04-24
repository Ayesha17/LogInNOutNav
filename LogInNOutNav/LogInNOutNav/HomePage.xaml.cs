using System;
using Xamarin.Forms;

namespace LogInNOutNav
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        public void OnNextClicked(object sender, EventArgs args)
        {
            Navigation.PushAsync(new FirstPage());
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (!App.IsLoggedIn)
            {
                var vLoginPage = new LoginPage();
                Navigation.InsertPageBefore(vLoginPage, this);
                Navigation.PopAsync(); }
        }
    }
}
