using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PDC03_MODULE04
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class activity05 : ContentPage
    {
        List<Contacts> contacts;
        public activity05()
        {
            InitializeComponent();

            SetupData();
            listView.ItemsSource = contacts;
        }

        void SetupData()
        {
            contacts = new List<Contacts>();

            contacts.Add(new Contacts
            {
                Name = "Calvin Kent R. Pamandanan",
                Age = 20,
                Occupation = "CEO",
                Country = "Philippines"
            });

            contacts.Add(new Contacts
            {
                Name = "Jello P. Mangune",
                Age = 69,
                Occupation = "Janitor",
                Country = "Philippines"
            });

            contacts.Add(new Contacts
            {
                Name = "Bobbeh Marcko L. Cruze",
                Age = 21,
                Occupation = "Manager",
                Country = "Philippines"
            });
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if(listView.SelectedItem != null)
            {
                var detailPage = new DetailPage();
                detailPage.BindingContext = e.SelectedItem as Contacts;
                listView.SelectedItem = null;
                await Navigation.PushModalAsync(detailPage);
            }
        }
    }
}