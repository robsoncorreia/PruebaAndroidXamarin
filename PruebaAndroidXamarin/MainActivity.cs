using Android.App;
using Android.Widget;
using Android.OS;

namespace PruebaAndroidXamarin
{
    [Activity(Label = "Prueba Android Xamarin", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);
            Button btnCalc = FindViewById<Button>(Resource.Id.btnCalc);
            EditText txtReal = FindViewById<EditText>(Resource.Id.txtReal);
            EditText txtDola = FindViewById<EditText>(Resource.Id.txtDola);
            double dola, real;
            btnCalc.Click += delegate
            {
                try
                {
                    dola = double.Parse(txtDola.Text);
                    real = dola * 3.11f;
                    txtReal.Text = real.ToString();

                }
                catch (System.Exception ex)
                {

                    Toast.MakeText(this, ex.Message, ToastLength.Short).Show();
                }
            };
        }
    }
}

