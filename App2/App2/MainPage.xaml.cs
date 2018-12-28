using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
        }

        private async void SayHelloBtn_Clicked(object sender, EventArgs e)
        {

            var name = NameEntry.Text;
            await DisplayAlert("Greeting", $"Hello {name}!", "Bye");

        }
    }
}
