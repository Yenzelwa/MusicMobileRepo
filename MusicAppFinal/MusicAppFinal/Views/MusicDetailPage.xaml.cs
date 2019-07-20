using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using MusicAppFinal.BLL.Library;
using MusicAppFinal.Models;
using Plugin.MediaManager;
using Plugin.MediaManager.Abstractions.Enums;
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
                var price = Math.Round(library.Price??0 ,2);
                LblPrice.Text = "R" + price;
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
          //  PopupNavigation.Instance.PushAsync(new PaymentPagePopUp());

        }
        //private bool _isClicked = false;
        //private void SongListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        //{
        //   // SlAudioPlayer.IsVisible = true;
        //    var song = e.SelectedItem as ApiLibraryDetail;
        //    CrossMediaManager.Current.PlayingChanged += Current_PlayingChanged;
        //    if (song != null)
        //    {
        //        CrossMediaManager.Current.Play(new MediaFile(song.FilePath, MediaFileType.Audio));
        //        CrossMediaManager.Current.PlaybackController.Play();
        //        // ImgPausePlay.Source = ImageSource.FromFile("pause.png");
        //    }


        //    //if (_isClicked)
        //    //{
        //    //    CrossMediaManager.Current.PlaybackController.Play();
        //    //  //  ImgPausePlay.Source = ImageSource.FromFile("pause.png");
        //    //    _isClicked = false;
        //    //}
        //    //else
        //    //{
        //    //    CrossMediaManager.Current.Pause();
        //    //   // ImgPausePlay.Source = ImageSource.FromFile("play.png");
        //    //    _isClicked = true;
        //    //}
        //}

 
        private bool _isClicked = false;
        private void TapPausePlay_OnTapped(object sender, EventArgs e)
        {
            _isClicked = !_isClicked;
            var img = ((Image)sender);
            if (img.BindingContext is ApiLibraryDetail libraryDetail)
            {
                if (_isClicked)
                {
                    CrossMediaManager.Current.PlayingChanged += Current_PlayingChanged;
                    CrossMediaManager.Current.Play( libraryDetail.FilePath, MediaFileType.Audio);
                    img.Source = ImageSource.FromFile("pause.png");
                }
                else
                {
                    CrossMediaManager.Current.Pause();
                    img.Source = ImageSource.FromFile("play.png");
                }
            }
        }
        private void Current_PlayingChanged(object sender, Plugin.MediaManager.Abstractions.EventArguments.PlayingChangedEventArgs e)
        {
            PbAudio.Progress = e.Progress / 100;
        }
    }
}