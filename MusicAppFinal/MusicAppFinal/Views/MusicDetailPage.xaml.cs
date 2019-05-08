﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
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
                    Cast = "Sjava",
                    Description = "A young African-American visits his white girlfriend's parents for the weekend, where his simmering uneasiness about their reception of him eventually reaches a boiling point.",
                    Duration = "05:01 Minutes",
                    Logo = "~/Content/NowPlayingMovies/Blade_Runner_2049_poster.png",
                    LogoFile = "Bladeposter.png",
                    MovieId = 5,
                    MovieLanguage = "R & B",
                    MovieName = "2Umphako",
                    MoviePrint = "1",
                    MovieType = "Horror, Mystery, Thriller",
                    RatedPGI = "PG 13",
                    ShowTime = "2019-01-01 17:00",
                    TicketPrice = "1",
                    TrailorLink = "https://www.youtube.com/embed/DzfpyUB60YY"

                };
                var songs = new List<SongModel>();
                var song = new SongModel
                {
                    Id = 1,
                    Name = "Umama",
                    FilePath = "ererwe",
                    Price = 50
                };
                songs.Add(song);
                var song1 = new SongModel
                {
                    Id = 1,
                    Name = "Izitha",
                    FilePath = "ererwe",
                    Price = 10
                };
                songs.Add(song1);
                var song2 = new SongModel
                {
                    Id = 1,
                    Name = "Abangani",
                    FilePath = "ererwe",
                    Price = 20
                };
                songs.Add(song2);
                var song3 = new SongModel
                {
                    Id = 1,
                    Name = "Intombi",
                    FilePath = "ererwe",
                    Price = 30
                };
                songs.Add(song3);



                LblMovieName.Text = movies.MovieName;
                LblType.Text = movies.MovieType;
        
                LblPrice.Text = "$" + movies.TicketPrice;
                LblLanguage.Text = movies.MovieLanguage;
                LblDescription.Text = movies.Description;
                ImgDetail.Source = "Bladeposter.png";
                trailorUrl = movies.TrailorLink;

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