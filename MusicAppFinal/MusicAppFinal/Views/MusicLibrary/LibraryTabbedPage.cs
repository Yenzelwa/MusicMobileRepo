using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MusicAppFinal.Views.MusicLibrary
{
    public class LibraryTabbedPage : TabbedPage
    {
        public LibraryTabbedPage()
        {
            Children.Add(new PlaylistPage()
            {
                Title = "PLAYLISTS",
                Icon = Device.OnPlatform<string>("tab_feed.png", null, null)
            });
            Children.Add(new ArtistPage()
            {
                Title = "ARTISTS",
                Icon = Device.OnPlatform<string>("tab_about.png", null, null)
            });
            Children.Add(new AlbumPage()
            {
                Title = "ALBUMS",
                Icon = Device.OnPlatform<string>("tab_about.png", null, null)

            });
            Children.Add(new SongPage()
            {
                Title = "SONGS",
                Icon = Device.OnPlatform<string>("tab_about.png", null, null)

            });



        }
    }
}
