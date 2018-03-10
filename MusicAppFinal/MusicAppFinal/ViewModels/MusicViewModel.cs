using MusicAppFinal.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicAppFinal.ViewModels
{
    public class MusicViewModel
    {
        
        
        public  MusicViewModel()
        {

            Music = new List<Music>();
            Music.Add(new Music
            {
                 CollectionArtistName = "Sanele Jili",
                 CollectionTitle = "Madumakude Very Nice",
                 CollectionImage = "IMG_0074.JPG",
                 CollectionPrice = 20
            });
            Music.Add(new Music
            {
                CollectionArtistName = "Nokukhanya Dumakude",
                CollectionTitle = "Majili Very  Bad",
                CollectionImage = "IMG_0078.JPG",
                CollectionPrice = 10
            });
        }

        public List<Music> Music { get; set; }








    }
}
