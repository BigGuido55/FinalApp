using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FinalApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class StartPage : ContentPage
	{
		public StartPage ()
		{
			InitializeComponent ();
		}

        public async void ToProfile()
        {
            await Navigation.PushAsync(new ProfilePage());
        }

        public async void GoBack()
        {
            await Navigation.PopAsync();
        }

        public async void ToBooking()
        {
            await Navigation.PushAsync(new FilterPage());
        }
	}
}