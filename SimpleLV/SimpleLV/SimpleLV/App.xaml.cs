using SimpleLV.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SimpleLV
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();
            MainPage = new ItemListPage();
        }
	}
}
