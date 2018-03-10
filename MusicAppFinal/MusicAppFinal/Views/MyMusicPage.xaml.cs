
using MusicAppFinal.ViewModels;

using Xamarin.Forms;

namespace MusicAppFinal.Views
{
	public partial class MyMusicPage : ContentPage
	{
		ItemDetailViewModel viewModel;

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
	}
}
