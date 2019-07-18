using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using MusicAppFinal.BLL.Library;
using MusicAppFinal.Models;
using MusicAppFinal.ViewModels;
using Newtonsoft.Json;
using Plugin.MediaManager;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MusicAppFinal.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MusicDetailPage : ContentPage
	{
        private string trailorUrl;
        public MusicDetailPage (ApiLibrary library)
		{
			InitializeComponent ();
            GetUpComingMovie(library);
            //   BindingContext = new MusicDetailViewModel();
        }
        private async void GetUpComingMovie(ApiLibrary library)
        {
            // GridMoviesDetail.IsVisible = false;

            try
            {
                SLLoader.IsVisible = true;

                var response = await Library.GetLibraryDetail(library.Id);
                var songs = response.ResponseObject;
               
                LblMovieName.Text = library.Artist;
                LblType.Text = library.Type;
        
                LblPrice.Text = "R" + library.Price;
                LblLanguage.Text = library.Type;
                LblDescription.Text = library.Description;
                ImgDetail.Source = library.CoverFilePath;

                SongListView.ItemsSource = songs;
                GridMoviesDetail.IsVisible = true;


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

        private void BtnBookOrder_OnClicked(object sender, EventArgs e)
        {
           // Navigation.PushAsync(new OrderPage(LblMovieName.Text, LblPrice.Text.Substring(1)));
        }

        private void BtnTrailor_OnClicked(object sender, EventArgs e)
        {
           // Navigation.PushAsync(new YoutubePage(trailorUrl));
        }
        private void Payment_Clicked(object sender, EventArgs e)
        {
            PopupNavigation.Instance.PushAsync(new PaymentPagePopUp());

        }
        private bool _isClicked = false;
        private void TapPausePlay_OnTapped(object sender, EventArgs e)
        {
            if (_isClicked)
            {
                CrossMediaManager.Current.PlaybackController.Play();
              //  ImgPausePlay.Source = ImageSource.FromFile("pause.png");
                _isClicked = false;
            }
            else
            {
                CrossMediaManager.Current.Pause();
               // ImgPausePlay.Source = ImageSource.FromFile("play.png");
                _isClicked = true;
            }
        }
    }
}