using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PDC03_MODULE04
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OpenActivity01(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new activity01());
        }

        private async void OpenActivity02(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new activity02());
        }

        private async void OpenActivity03(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new activity03());
        }

        private async void OpenActivity04(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new activity04());
        }

        private async void OpenActivity05(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new activity05());
        }
    }
}
