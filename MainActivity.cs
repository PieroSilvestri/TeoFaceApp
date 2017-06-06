using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace TeoFaceApp
{
	[Activity(Label = "TeoFaceApp", MainLauncher = true)]
	public class MainActivity : Activity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			Button btnRegistration = FindViewById<Button>(Resource.Id.btnRegistration);
			btnRegistration.Click += BtnRegistration_Click;
		}

		void BtnRegistration_Click(object sender, System.EventArgs e)
		{
			Intent intent = new Intent(this, typeof(RegistrationActivity));
			StartActivity(intent);
		}
	}
}

