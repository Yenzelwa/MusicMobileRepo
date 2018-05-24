using MusicAppFinal.Views;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace MusicAppFinal
{
	public partial class App : Application
	{
        public static bool IsWindows10 { get; set; }

        public App()
        {
            InitializeComponent();

            MainPage =  new RootPage();
           
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
