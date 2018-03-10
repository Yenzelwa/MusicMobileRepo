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
            BindingContext = new MusicViewModel();

            //AlbumArrayList = new List<AlbumModel>();
            //AlbumArrayList.Add(new AlbumModel { Id = 1, Name = "Lemonade", FK_SingerId = 1, Price = 23, ImageSource = "IMG_0078.JPG" });
            //AlbumArrayList.Add(new AlbumModel { Id = 1, Name = "Lemonade2", FK_SingerId = 1, Price = 23, ImageSource = "IMG_0308.JPG" });
            //AlbumArrayList.Add(new AlbumModel { Id = 1, Name = "Lemonade3", FK_SingerId = 1, Price = 23, ImageSource = "IMG_0437.JPG" });
            //AlbumArrayList.Add(new AlbumModel { Id = 1, Name = "Lemonade4", FK_SingerId = 1, Price = 23, ImageSource = "IMG_0074.JPG" });

            //gridLayout.RowDefinitions.Add(new RowDefinition());
            //gridLayout.RowDefinitions.Add(new RowDefinition());
            //gridLayout.ColumnDefinitions.Add(new ColumnDefinition());
            //gridLayout.ColumnDefinitions.Add(new ColumnDefinition());
            //gridLayout.ColumnDefinitions.Add(new ColumnDefinition());

            //var productIndex = 0;
            //for (int rowIndex = 0; rowIndex < 2; rowIndex++)
            //{
            //    for (int columnIndex = 0; columnIndex < 3; columnIndex++)
            //    {
            //        if (productIndex >= AlbumArrayList.Count) break;
            //        var album = AlbumArrayList[productIndex];
            //        productIndex += 1;

            //        var label = new Label
            //        {
            //            Text = album.Name,
            //            VerticalOptions = LayoutOptions.Center,
            //            HorizontalOptions = LayoutOptions.Center
            //        };

            //        var image = new Image
            //        {
            //            Aspect = Aspect.AspectFit,
            //            Source = album.ImageSource
            //        };
            //        gridLayout.Children.Add(image, columnIndex, rowIndex);
            //        gridLayout.Children.Add(label, columnIndex, rowIndex);
            //    }

            // }

            // BindingContext = viewModel = new ItemsViewModel();
        }

        //protected override async void OnAppearing()
        //{
        //    base.OnAppearing();

        //    var images = new List<string>();
        //    var image1 = "IMG_0078.JPG";
        //    var image2 = "IMG_0308.JPG";
        //    var image3 = "IMG_0437.JPG";
        //    var image4 = "IMG_0074.JPG";
        //    images.Add(image1);
        //    images.Add(image2);
        //    images.Add(image3);
        //    images.Add(image4);

        //    // await GetImageListAsync();
        //    foreach (var photo in images)
        //    {
        //        var image = new Image
        //        {
        //            Source = photo
        //        };
        //        wrapLayout.Children.Add(image);
        //    }
        //}



        //async Task<ImageList> GetImageListAsync()
        //{
        //    var requestUri = "https://docs.xamarin.com/demo/stock.json";
        //    using (var client = new HttpClient())
        //    {
        //        var result = await client.GetStringAsync(requestUri);
        //        return JsonConvert.DeserializeObject<ImageList>(result);
        //    }
        //}

        //async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        //{
        //    var item = args.SelectedItem as Item;
        //    if (item == null)
        //        return;

        //    await Navigation.PushAsync(new MyMusicPage(new ItemDetailViewModel(item)));

        //    // Manually deselect item
        //    //ItemsListView.SelectedItem = null;
        //}

        //async void AddItem_Clicked(object sender, EventArgs e)
        //{
        //    await Navigation.PushAsync(new NewItemPage());
        //}

        //protected override void OnAppearing()
        //{
        //base.OnAppearing();

        //if (viewModel.Items.Count == 0)
        //viewModel.LoadItemsCommand.Execute(null);
        //}

        async void OnTapped_ViewMusic(object sender, EventArgs e)
        {
            App.Current.MainPage = new MusicDetailPage();
        }




    }
}



