using System;
using Xamarin.Forms;

namespace LogInNOutNav
{
    public partial class ThirdPage : ContentPage
    {
        public ThirdPage()
        {
            InitializeComponent();
        }
        public void OnNextClicked(object sender, EventArgs args)
        {
            Navigation.PushAsync(new FourthPage());
        }
    }
}
