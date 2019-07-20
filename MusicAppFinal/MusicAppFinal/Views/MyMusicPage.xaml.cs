
using MusicAppFinal.ViewModels;
using System;
using Xamarin.Forms;


namespace MusicAppFinal.Views
{
	public partial class MyMusicPage : TabbedPage
	{
		ItemDetailViewModel viewModel;

        string videoUrl = "https://sec.ch9.ms/ch9/37af/240037cc-e74a-421a-9946-7ce4205d37af/DiAndIocForXamarinForms.mp4";
        // Note - The Xamarin.Forms Previewer requires a default, parameterless constructor to render a page.
        public MyMusicPage()
        {
            InitializeComponent();
        }

        public MyMusicPage(ItemDetailViewModel viewModel)
		{
			InitializeComponent();

			BindingContext = this.viewModel = viewModel;
		}
        //private void PlayStop_Clicked(object sender, EventArgs e)
        //{
        //    if(PlayStop.Text=="Play")
        //    {
        //        CrossMediaManager.Current.Play(videoUrl,MediaFileType.Video);
        //        PlayStop.Text = "Stop";
        //    }
        //    else if(PlayStop.Text=="Stop")
        //    {
        //        CrossMediaManager.Current.Stop();
        //        PlayStop.Text = "Play";
        //    }

        //}
	}
}
