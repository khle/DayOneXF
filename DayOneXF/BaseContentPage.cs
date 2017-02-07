using Xamarin.Forms;

namespace DayOneXF
{
	public class BaseContentPage : ContentPage
	{
		public void SendAppearing()
		{
			OnAppearing();
		}

		public void SendDisappearing()
		{
			OnDisappearing();
		}
	}
}
