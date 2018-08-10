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

            MainPage =  new LoginPage();
            //SET PRIMARY TOOLBAR COLOR
            MainPage.Resources = new ResourceDictionary();
            Color xamarin_color = Color.FromHex("#232323");
            var navigationStyle = new Style(typeof(NavigationPage));
            var barBackgroundColorSetter = new Setter { Property = NavigationPage.BarBackgroundColorProperty, Value = xamarin_color };
            navigationStyle.Setters.Add(barBackgroundColorSetter);
            MainPage.Resources.Add(navigationStyle);

            //Background color
            MainPage.SetValue(NavigationPage.BarBackgroundColorProperty, Color.Black);

            //Title color
            MainPage.SetValue(NavigationPage.BarTextColorProperty, Color.White);

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
