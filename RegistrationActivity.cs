
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace TeoFaceApp
{
	[Activity(Label = "RegistrationActivity")]
	public class RegistrationActivity : Activity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Create your application here
			SetContentView(Resource.Layout.Registration);

			Button btnDone = FindViewById<Button>(Resource.Id.btnDone);
			btnDone.Click += BtnDone_Click;

		}

		void BtnDone_Click(object sender, EventArgs e)
		{
			var name = FindViewById<EditText>(Resource.Id.editTextName);
			var surname = FindViewById<EditText>(Resource.Id.editTextSurname);
			var email = FindViewById<EditText>(Resource.Id.editTextEmail);

			if (name.Text == "" || surname.Text == "" || email.Text == "")
			{
				Toast.MakeText(this, "ciao", ToastLength.Short).Show();
			}
		}
	}
}
