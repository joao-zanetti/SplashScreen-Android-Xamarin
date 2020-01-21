using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Views;

namespace SplashScreen
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private ProgressBar _progressBarSplash;
        private TextView _labelVersionapp;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_splash);

            _progressBarSplash = FindViewById<ProgressBar>(Resource.Id.progressBarSplash);
            _labelVersionapp = FindViewById<TextView>(Resource.Id.labelVersionapp);

            //Version of App
            _labelVersionapp.Text = "1.0";
            _progressBarSplash.Visibility = ViewStates.Visible;

        }


        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}