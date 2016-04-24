
using System;
using Xamarin.Forms;

namespace LogInNOutNav
{
    public partial class FirstPage : ContentPage
    {
        public FirstPage()
        {
            InitializeComponent();
        }
        public void OnNextClicked(object sender, EventArgs args)
        {
            Navigation.PushAsync(new SecondPage());
        }

    }
}
