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
	public partial class BeginPage : ContentPage
	{
		public BeginPage ()
		{
			InitializeComponent ();
		}

        public async void ChangePage()
        {
            await Navigation.PopAsync();                    //pokusaj uklanjanja login prozora
            await Navigation.PushAsync(new StartPage());            
        }
	}
}