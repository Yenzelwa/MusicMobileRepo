using MusicAppFinal.Models;
using System;
using System.Collections.Generic;
using System.Text;
using static MusicAppFinal.Models.Music;

namespace MusicAppFinal.ViewModels
{
    public class MusicViewModel
    {
        
        
        public  MusicViewModel()
        {

            //People = new List<PeoplePair>
            //{
            //    new PeoplePair(new Person(), new Person()),
            //    new PeoplePair(new Person(), new Person()),
            //    new PeoplePair(new Person(), new Person()),
            //    new PeoplePair(new Person(), null)
            //};
            Music = new List<MusicPair>{
                new MusicPair ( new Music
            {
                 CollectionArtistName = "Sanele Jili",
                 CollectionTitle = "Madumakude Very Nice",
                 CollectionImage = "IMG_0074.JPG",
                 CollectionPrice = 20
            },
            new Music
            {
                CollectionArtistName = "Nokukhanya Dumakude",
                CollectionTitle = "Majili Very  Bad",
                CollectionImage = "IMG_0078.JPG",
                CollectionPrice = 10
            }),
                   new MusicPair ( new Music
            {
                 CollectionArtistName = "Sanele Jili 2",
                 CollectionTitle = "Madumakude Very Nice",
                 CollectionImage = "IMG_0074.JPG",
                 CollectionPrice = 20
            },
            new Music
            {
                CollectionArtistName = "Nokukhanya Dumakude 2",
                CollectionTitle = "Majili Very  Bad",
                CollectionImage = "IMG_0078.JPG",
                CollectionPrice = 10
            })
            };
        }

        public List<MusicPair> Music { get; set; }








    }
}
