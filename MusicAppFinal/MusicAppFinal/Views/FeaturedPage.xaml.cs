using System;
using MusicAppFinal.Models;
using MusicAppFinal.ViewModels;
using Xamarin.Forms;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using ImageWrapLayout;
using System.Net;
using MusicAppFinal.BLL.Library;

namespace MusicAppFinal.Views
{
    public partial class FeaturedPage : ContentPage
    {

        public FeaturedPage()
        {
            InitializeComponent();
            GetMovies();


        }

        public async void GetMovies()
        {
           
            SLMovies.IsVisible = false;

            try
            {
                SLLoader.IsVisible = true;
       
               var response = await Library.GetLibrary();
                MovieListView.ItemsSource = response.ResponseObject;
                SLMovies.IsVisible = true;

            }
            catch (Exception e)
            {
                SLLoader.IsVisible = false;
                throw;
            }
            finally
            {
                SLLoader.IsVisible = false;
            }

        }

        private void MovieListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            //if (((ListView)sender).SelectedItem == null)
            //    return;
            ////Do stuff here with the SelectedItem ...

            var selectedItem = e.SelectedItem as ApiLibrary;

            if (selectedItem != null)
            {
                Navigation.PushAsync(new MusicDetailPage(selectedItem));
            }
            ((ListView)sender).SelectedItem = null;

        }
        //protected override bool OnBackButtonPressed()
        //{
        //    return true;
        }
        //private async void Button_OnClicked(object sender, EventArgs e)
        //{
        //    await Navigation.PushAsync(new MusicDetailPage());
        //}
        //public double clicks = 0;

 

        //private void BtnIncrement_OnClicked(object sender, EventArgs e)
        //{
        //    clicks += 1;
        //    CustomNavigationBar bar = new CustomNavigationBar();
        //    bar.FirstNameLabel.Text = clicks.ToString();


        //   // NavigationBarView.FirstNameLabel.Text = clicks.ToString();
        //}


        //async void OnTapped_ViewMusic(object sender, EventArgs e)
        //{
        //   await Navigation.PushAsync(new MusicDetailPage());
        //}




    }




