using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FinalApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FinalizePage : ContentPage
	{
		public FinalizePage ()
		{
			InitializeComponent();
		}

        public async void BackToStart()
        {
            await Navigation.PopToRootAsync();
            /*Thread.Sleep(1000);
            await Navigation.PushAsync(new StartPage());*/
        }
	}
}