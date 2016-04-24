
using Xamarin.Forms;

namespace LogInNOutNav
{
    public class App : Application
    {
        public static bool IsLoggedIn { get; set; }
        public App()
        {
            IsLoggedIn = false;
            // The root page of your application
            if (IsLoggedIn)
            { MainPage = new NavigationPage(new HomePage()); }
            else MainPage = new NavigationPage(new LoginPage());

        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
