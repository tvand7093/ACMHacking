using System;

using Xamarin.Forms;

namespace ACMHack
{
	public class App : Application
	{
		public App ()
		{
			// The root page of your application,
			//set a new home page to the content of a navigation page.
			//the navigation page lets us have a title
			//and can be used to push new views onto the screen.
			MainPage = new NavigationPage(new HomePage());
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

