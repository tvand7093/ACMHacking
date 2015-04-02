using System;

using Xamarin.Forms;

namespace ACMHack
{
	public class HomePage : ContentPage
	{
		public HomePage ()
		{
			Title = "Home";
			var button = new Button () {
				Text = "Click me!",
				HorizontalOptions = LayoutOptions.Fill,
				VerticalOptions = LayoutOptions.End
			};


			var label = new Label () {
				Text = "Hello world!",
				VerticalOptions = LayoutOptions.Center,
				HorizontalOptions = LayoutOptions.CenterAndExpand
			};

			var textBox = new Entry () {
				HorizontalOptions = LayoutOptions.Fill,
				VerticalOptions = LayoutOptions.Fill
			};
					
			button.Clicked += (object sender, EventArgs e) => {
				label.Text = String.IsNullOrEmpty(textBox.Text) ? "You didn't set text!" : textBox.Text;
			};

			Content = new StackLayout { 
				Children = {
					new StackLayout {
						Children = {
							label, textBox
						},
						HorizontalOptions = LayoutOptions.FillAndExpand,
						VerticalOptions = LayoutOptions.CenterAndExpand,
					},
					button
				},
				HorizontalOptions = LayoutOptions.FillAndExpand,
				VerticalOptions = LayoutOptions.FillAndExpand,
				Padding = new Thickness(20)
			};
		}
	}
}


