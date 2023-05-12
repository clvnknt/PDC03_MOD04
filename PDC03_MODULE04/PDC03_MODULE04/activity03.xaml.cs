using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PDC03_MODULE04
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class activity03 : ContentPage
    {
        public activity03()
        {
            InitializeComponent();
        }

        private async void onNextPage(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new activity03Page2());
        }

        private async void onPreviousPage(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}