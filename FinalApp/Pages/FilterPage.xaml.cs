using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FinalApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FilterPage : ContentPage
	{
        public Boolean SelectionButton { get; set; }
        int Capacity { get; set; }

		public FilterPage ()
		{
			InitializeComponent ();
            SelectionButton = false;
		}

        ICommand enablingButton;
        public ICommand EnablingButton => enablingButton ?? (enablingButton = new Command<string>(EnableSelectionButton));

        public void EnableSelectionButton(string text)
        {
            try
            {
                Capacity = Convert.ToInt32(text);
                if (Capacity >= 0 && Capacity <= 100) SelectionButton = true;
                else SelectionButton = false;
            }
            catch
            {
                SelectionButton = false;
            }
        }

        public async void ToList()
        {
            await Navigation.PushAsync(new SelectionPage(Capacity));
        }
	}
}