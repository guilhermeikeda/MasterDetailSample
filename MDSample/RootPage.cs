using System;

using Xamarin.Forms;

namespace MDSample
{
	public class RootPage : MasterDetailPage
	{
		public RootPage()
		{
			Master = new Feed();
		}
	}
}


