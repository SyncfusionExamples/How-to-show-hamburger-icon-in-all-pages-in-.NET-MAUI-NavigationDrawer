namespace Navigation;

public class ProfilePage : ContentPage
{
	public ProfilePage()
	{
		Content = new VerticalStackLayout
		{
			Children = {
				new Label { HorizontalOptions = LayoutOptions.Center, 
					VerticalOptions = LayoutOptions.Center, 
					Text = "Welcome to Profile page"
				}
			}
		};
	}
}