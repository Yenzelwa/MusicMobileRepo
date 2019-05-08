using MusicAppFinal.Controller;
using MusicAppFinal.Models;
using MusicAppFinal.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MusicAppFinal.Views
{
    public class RootPage : MasterDetailPage
    {
        public static bool IsUWPDesktop { get; set; }
        Dictionary<int, NavigationPage> Pages { get; set; }
        public RootPage()
        {
            if (IsUWPDesktop)
                this.MasterBehavior = MasterBehavior.Popover;

            Pages = new Dictionary<int, NavigationPage>();
            //ToolbarItem cart = new ToolbarItem()
            //{

            //    Text = "0",
            //    Icon = "ShoppingCart.png",
            //  StyleId= "LightTextColor"

            //};
  
            //ToolbarItem cout = new ToolbarItem()
            //{
            //    Text = "0"
               


            //};

            //cart.Clicked += async (object sender, System.EventArgs e) =>
            //{
            //    await DisplayAlert("Done", "Msg", "Ok", "Can");
            //};

            //ToolbarItems.Add(cart);
            //ToolbarItems.Add(cout);

            Master = new MenuPage(this);
            BindingContext = new BaseViewModel
            {
                Title = "Music",
                Icon = "slideout.png"
            };
            //setup home page
            Pages.Add((int)MenuType.Browse, new MusicAppNavigationPage(new HomeTabbedPage()));
            Detail = Pages[(int)MenuType.Browse];

            InvalidateMeasure();
        }



        public async Task NavigateAsync(int id)
        {

            if (Detail != null)
            {
                if (IsUWPDesktop || Device.Idiom != TargetIdiom.Tablet)
                    IsPresented = false;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(300);
            }

            Page newPage;
            if (!Pages.ContainsKey(id))
            {

                switch (id)
                {
                    case (int)MenuType.Browse:
                        Pages.Add(id, new MusicAppNavigationPage(new HomeTabbedPage()));
                        break;
                    case (int)MenuType.About:
                        Pages.Add(id, new MusicAppNavigationPage(new NewItemPage()));
                        break;
                    case (int)MenuType.Blog:
                        Pages.Add(id, new MusicAppNavigationPage(new NewItemPage()));
                        break;
                    case (int)MenuType.Videos:
                        Pages.Add(id, new MusicAppNavigationPage(new NewItemPage()));
                        break;
                    
                }
            }

            newPage = Pages[id];
            if (newPage == null)
                return;

            //pop to root for Windows Phone
            if (Detail != null && Device.RuntimePlatform == Device.WinPhone)
            {
                await Detail.Navigation.PopToRootAsync();
            }

            Detail = newPage;
        }
    }
}
