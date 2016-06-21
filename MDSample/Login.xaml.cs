using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MDSample
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Login : ContentPage
	{
		public Login()
		{
			InitializeComponent();

			LoginBtn.Clicked +=Login_Clicked;
			/*
			LoginButton.Clicked += delegate
			 {
				 App.Current.MainPage = new RootPage();
			 };
			 */
		}
		private void Login_Clicked(object sender, EventArgs e)
		{
			App.Current.MainPage = new NavigationPage(new RootPage());
		}

	}
}

