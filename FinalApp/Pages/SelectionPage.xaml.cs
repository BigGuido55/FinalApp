using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FinalApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SelectionPage : ContentPage
    {
        public ObservableCollection<string> Items { get; set; }
        ObservableCollection<Dvorana> AllItems = new ObservableCollection<Dvorana>()
        {
            new Dvorana { Name="D1", Capacity=55, Floor = 1 },
            new Dvorana { Name="D2", Capacity=20, Floor = 0 },
            new Dvorana { Name="A11", Capacity=30, Floor = 0 },
            new Dvorana { Name="C25", Capacity=40, Floor = 0 },
            new Dvorana { Name="B1", Capacity=15, Floor = 2 },
            new Dvorana { Name="B35", Capacity=80, Floor = 1 },
            new Dvorana { Name="D58", Capacity=60, Floor = 2 },
            new Dvorana { Name="D10", Capacity=30, Floor = 2 },
            new Dvorana { Name="A75", Capacity=45, Floor = 2 },
            new Dvorana { Name="B11", Capacity=10, Floor = 1 },
            new Dvorana { Name="B60", Capacity=95, Floor = 1 },
            new Dvorana { Name="C5", Capacity=70, Floor = 0 },
            new Dvorana { Name="C13", Capacity=25, Floor = 0 },
            new Dvorana { Name="E0", Capacity=50, Floor = 1 }
        };
        public SelectionPage(int capacity)
        {
            InitializeComponent();

            Items = new ObservableCollection<string>();
            foreach(Dvorana dvorana in AllItems)
            {
                if (dvorana.Capacity >= capacity) Items.Add(new string(dvorana.Name + " kapacitet:" + dvorana.Capacity+ " kat:" + dvorana.Floor));
            }

			MyListView.ItemsSource = Items;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }

        public async void ToFinalize()
        {
            await Navigation.PushAsync(new FinalizePage());
        }
    }
}
