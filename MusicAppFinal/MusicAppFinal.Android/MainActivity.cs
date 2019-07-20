using Android.App;
using Android.Content.PM;
using Android.OS;
using Plugin.MediaManager.Forms.Android;

namespace MusicAppFinal.Droid
{
    [Activity(Label = "JukeBox World", Theme = "@style/MyTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

           // Rg.Plugins.Popup.Popup.Init(this, bundle);
            VideoViewRenderer.Init();

            global::Xamarin.Forms.Forms.Init(this, bundle);

            LoadApplication(new App());
        }
    }
}