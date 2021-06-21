using App1.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemsVacinePage : ContentPage
    {
        public ItemsVacinePage()
        {
            Title = "Vacinas COVID-19";
            InitializeComponent();
            CarregaListView();
        }

        private void CarregaListView()
        {
            ObservableCollection <Vacine> lista = new ObservableCollection<Vacine>();
            lista.Add(new Vacine { Text = "AstraZeneca", Enterprise = "Oxford" });
            lista.Add(new Vacine { Text = "BBIBP-CorV", Enterprise = "Sinopharm" });
            lista.Add(new Vacine { Text = "CoronaVac", Enterprise = "Sinovac Biotech" });
            lista.Add(new Vacine { Text = "Janssen", Enterprise = "Johnson & Johnson" });
            lista.Add(new Vacine { Text = "Moderna", Enterprise = "Cambridge, Massachusetts" });
            lista.Add(new Vacine { Text = "Pfizer", Enterprise = "BioNTech " });
            listView.ItemsSource = lista;
        }
    }
}