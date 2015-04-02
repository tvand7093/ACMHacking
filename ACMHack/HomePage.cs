using System;

using Xamarin.Forms;

namespace ACMHack
{
	public class HomePage : ContentPage
	{
		public HomePage ()
		{
			//set the title of the navigation control
			Title = "Home";

			//create the clickable button
			var button = new Button () {
				
				//set it's text to display
				Text = "Click me!",

				//make the button fill up screen space horizontally.
				HorizontalOptions = LayoutOptions.Fill,

				//make the button be at the end of the content horizontally.
				VerticalOptions = LayoutOptions.End
			};

			//create the label for displaying stuff
			var label = new Label () {
				
				//set the default text
				Text = "Hello world!",

				//center the text vertically
				VerticalOptions = LayoutOptions.Center,

				//center the text horizontally
				HorizontalOptions = LayoutOptions.Center
			};

			//create the text box we can type in
			var textBox = new Entry () {

				//fill all space horizontally
				HorizontalOptions = LayoutOptions.Fill,

				//fill all space vertically
				VerticalOptions = LayoutOptions.Fill
			};

			//specify what happens when the button gets clicked.
			button.Clicked += (object sender, EventArgs e) => {
				//set the label text to that which is entered in the text box.
				label.Text =  String.IsNullOrEmpty(textBox.Text) ? "You didn't set text!" : textBox.Text;
			};

			//set the main content for the page to a list of stacked items.
			Content = new StackLayout { 
				//the items in the list
				Children = {
					//a stack that contains our label and text box
					new StackLayout {
						//add the label and textbox to the container
						Children = {
							label, textBox
						},
						//make the container fill all horizontal space and center it vertically
						HorizontalOptions = LayoutOptions.FillAndExpand,
						VerticalOptions = LayoutOptions.CenterAndExpand,
					},
					//add the button to the end of the container.
					button
				},
				//make sure we tell it to fill all screen space available.
				HorizontalOptions = LayoutOptions.FillAndExpand,
				VerticalOptions = LayoutOptions.FillAndExpand,

				//add a gutter to all sides
				Padding = new Thickness(20)
			};
		}
	}
}


