using MusicAppFinal.Models;
using MusicAppFinal.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MusicAppFinal.Views
{
  
    public partial class MenuPage : ContentPage
    {
        RootPage root;
        List<HomeMenuItem> menuItems;
        public MenuPage(RootPage root)
        {
            this.root = root;
            InitializeComponent();
            if (!App.IsWindows10)
            {
                BackgroundColor = Color.FromHex("#232323");
                ListViewMenu.BackgroundColor = Color.FromHex("#232323");
            }
            BindingContext = new BaseViewModel
            {
                Title = "Hanselman.Forms",
                Subtitle = "Hanselman.Forms",
                Icon = "slideout.png"
            };

            ListViewMenu.ItemsSource = menuItems = new List<HomeMenuItem>
                {
                    new HomeMenuItem { Title = "Browse", MenuType = MenuType.Browse, Icon ="about.png" },
                    new HomeMenuItem { Title = "About", MenuType = MenuType.About, Icon = "blog.png" },
                    new HomeMenuItem { Title = "Blog", MenuType = MenuType.Blog, Icon = "twitternav.png" },
                    new HomeMenuItem { Title = "Videos", MenuType = MenuType.Videos, Icon = "channel9.png"},

                };

            ListViewMenu.SelectedItem = menuItems[0];

            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (ListViewMenu.SelectedItem == null)
                    return;

                int testc = (int)((HomeMenuItem)e.SelectedItem).MenuType;
                await this.root.NavigateAsync(testc);
            };
        }

     
    }
}
	
