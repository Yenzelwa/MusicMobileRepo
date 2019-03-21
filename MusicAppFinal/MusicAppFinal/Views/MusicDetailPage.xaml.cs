using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using MusicAppFinal.Models;
using MusicAppFinal.ViewModels;
using Newtonsoft.Json;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MusicAppFinal.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MusicDetailPage : ContentPage
	{
        private string trailorUrl;
        public MusicDetailPage (float movieId)
		{
			InitializeComponent ();
            GetUpComingMovie(movieId);
            //   BindingContext = new MusicDetailViewModel();
        }
        private async void GetUpComingMovie(float id)
        {
            // GridMoviesDetail.IsVisible = false;

            try
            {
                SLLoader.IsVisible = true;

              //  HttpClient client = new HttpClient();
               // var response =
                //    await client.GetStringAsync("http://cinemo.azurewebsites.net/api/NowPlayingMovies/" + id);
               // var movies = JsonConvert.DeserializeObject<NowPlaying>(response);
                var movies = new NowPlaying
                {
                    Cast = "El Memo Lopez",
                    Description = "A young African-American visits his white girlfriend's parents for the weekend, where his simmering uneasiness about their reception of him eventually reaches a boiling point.",
                    Duration = "100 Minutes",
                    Logo = "~/Content/NowPlayingMovies/Blade_Runner_2049_poster.png",
                    LogoFile = "Bladeposter.png",
                    MovieId = 5,
                    MovieLanguage = "English",
                    MovieName = "Peñarol Noma!",
                    MoviePrint = "1",
                    MovieType = "Horror, Mystery, Thriller",
                    RatedPGI = "PG 13",
                    ShowTime = "2019-01-01 17:00",
                    TicketPrice = "1",
                    TrailorLink = "https://www.youtube.com/embed/DzfpyUB60YY"

                };

                LblMovieName.Text = movies.MovieName;
                LblType.Text = movies.MovieType;
        
                LblPrice.Text = "$" + movies.TicketPrice;
                LblLanguage.Text = movies.MovieLanguage;
                LblDescription.Text = movies.Description;
                ImgDetail.Source = "Bladeposter.png";
                trailorUrl = movies.TrailorLink;
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
    }
}