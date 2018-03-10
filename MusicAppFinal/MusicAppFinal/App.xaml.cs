using MusicAppFinal.Views;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace MusicAppFinal
{
	public partial class App : Application
	{
        public App()
		{
			InitializeComponent();

			SetMainPage();
		}

		public static void SetMainPage()
		{
            Current.MainPage = new TabbedPage
            {
                Children =
                {
                          new NavigationPage(new FeaturedPage())
                    {
                        Title = "FEATURED",
                        Icon = Device.OnPlatform<string>("tab_feed.png",null,null)
                    },
                    new NavigationPage(new BlogPage())
                    {
                        Title = "BLOG",
                        Icon = Device.OnPlatform<string>("tab_about.png",null,null)
                    },
                    new NavigationPage(new MyMusicPage())
                    {
                        Title = "MY MUSIC",
                        Icon = Device.OnPlatform<string>("tab_about.png",null,null)

                    },
                }
            };
        }
	}
}
