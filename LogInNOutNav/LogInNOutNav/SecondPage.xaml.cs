using System;
using Xamarin.Forms;

namespace LogInNOutNav
{
    public partial class SecondPage : ContentPage
    {
        public SecondPage()
        {
            InitializeComponent();
        }

        public void OnNextClicked(object sender, EventArgs args)
        {
            Navigation.PushAsync(new ThirdPage());
        }
    }
}
