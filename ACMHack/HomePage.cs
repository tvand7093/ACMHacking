using System;

using Xamarin.Forms;

namespace ACMHack
{
	public class HomePage : ContentPage
	{
		public HomePage ()
		{
			var button = new Button () {
				Text = "Click me!",
				HorizontalOptions = LayoutOptions.FillAndExpand,
				VerticalOptions = LayoutOptions.End
			};

			var label = new Label () {
				Text = "Hello world!",
				VerticalOptions = LayoutOptions.CenterAndExpand
			};

			button.Clicked += (object sender, EventArgs e) => {
				label.Text = "I changed it!";
			};

			Content = new StackLayout { 
				Children = {
					label, button
				},
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				VerticalOptions = LayoutOptions.FillAndExpand,
				Padding = new Thickness(20)
			};
		}
	}
}


