using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkingDemo2.View;
using Xamarin.Forms;

namespace WorkingDemo2
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}
        public void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page2());
        }
	}
}
