using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DayOneXF
{
	public partial class MainPage : TabbedPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();
			//SelectedItem = Children[1];
		}

		protected override void OnCurrentPageChanged()
		{
			base.OnCurrentPageChanged();

			Title = CurrentPage?.Title;
		}
	}
}
