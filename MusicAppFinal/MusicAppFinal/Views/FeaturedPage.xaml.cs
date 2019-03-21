using System;
using MusicAppFinal.Models;
using MusicAppFinal.ViewModels;
using Xamarin.Forms;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using ImageWrapLayout;

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
                HttpClient client = new HttpClient();
                var movies = new List<NowPlaying>();
                var movie1 = new NowPlaying
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
                movies.Add(movie1);
                var movie2 = new NowPlaying
                {
                    Cast = "Denis Villeneuve",
                    Description = "A young blade runner's discovery of a long-buried secret leads him to track down former blade runner Rick Deckard, who's been missing for thirty years.",
                    Duration = "160 Minutes",
                    Logo = "~/Content/NowPlayingMovies/Blade_Runner_2049_poster.png",
                    LogoFile = "Bladeposter.png",
                    MovieId = 4,
                    MovieLanguage = "English",
                    MovieName = "Blade Runner 2049 (2017)",
                    MoviePrint = "1",
                    MovieType = "Drama, Mystery, Sci-Fi",
                    RatedPGI = "PG 13",
                    ShowTime = "2019-01-01 17:00",
                    TicketPrice = "15",
                    TrailorLink = "https://www.youtube.com/embed/DzfpyUB60YY"

                };
                movies.Add(movie2);
                var movie3 = new NowPlaying
                {
                    Cast = "Christopher Nolan",
                    Description = "Allied soldiers from Belgium, the British Empire and France are surrounded by the German Army, and evacuated during a fierce battle in World War II.",
                    Duration = "120 Minutes",
                    Logo = "~/Content/NowPlayingMovies/Dunkirk_Film_poster.jpg",
                    LogoFile = "Bladeposter.png",
                    MovieId = 3,
                    MovieLanguage = "English",
                    MovieName = "Dunkirk (2017)",
                    MoviePrint = "1",
                    MovieType = "Action, Drama, History",
                    RatedPGI = "PG 13",
                    ShowTime = "2019-01-01 17:00",
                    TicketPrice = "15",
                    TrailorLink = "https://www.youtube.com/embed/DzfpyUB60YY"

                };
                movies.Add(movie3);
                var movie4 = new NowPlaying
                {
                    Cast = "Alex Kurtzman",
                    Description = "An ancient Egyptian princess is awakened from her crypt beneath the desert, bringing with her malevolence grown over millennia, and terrors that defy human comprehension.",
                    Duration = "115 นาที",
                    Logo = "~/Content/NowPlayingMovies/The_Mummy_(2017).jpg",
                    LogoFile = "Bladeposter.png",
                    MovieId = 2,
                    MovieLanguage = "English",
                    MovieName = "The Mummy (2017)",
                    MoviePrint = "1",
                    MovieType = "Action, Adventure, Fantasy",
                    RatedPGI = "PG 13",
                    ShowTime = "2019-01-01 17:00",
                    TicketPrice = "1",
                    TrailorLink = "https://www.youtube.com/embed/sCdV3esMr9M"

                };
                movies.Add(movie4);
                var movie5 = new NowPlaying
                {
                    Cast = "Ansel Elgort",
                    Description = "After being coerced into working for a crime boss, a young getaway driver finds himself taking part in a heist doomed to fail.",
                    Duration = "135 Minutes",
                    Logo = "~/Content/NowPlayingMovies/717QDxYBkbL._SY606_.jpg",
                    LogoFile = "Bladeposter.png",
                    MovieId = 2,
                    MovieLanguage = "English",
                    MovieName = "Baby Driver (2017)",
                    MoviePrint = "1",
                    MovieType = "Crime",
                    RatedPGI = "PG 13",
                    ShowTime = "2019-01-01 17:00",
                    TicketPrice = "15",
                    TrailorLink = "https://www.youtube.com/embed/D9YZw_X5UzQ"

                };
                movies.Add(movie5);

                //var response = await client.GetStringAsync("http://cinemo.azurewebsites.net/api/NowPlayingMovies");
                //var movies = JsonConvert.DeserializeObject<List<NowPlaying>>("");
                MovieListView.ItemsSource = movies;
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

            var selectedItem = e.SelectedItem as NowPlaying;

            if (selectedItem != null)
            {
                var id = selectedItem.MovieId;
                Navigation.PushAsync(new MusicDetailPage(id));
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




