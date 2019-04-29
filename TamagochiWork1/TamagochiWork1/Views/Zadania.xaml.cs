using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TamagochiWork1.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Zadania : ContentPage
	{
		public Zadania ()
		{
			InitializeComponent ();
		}
        private async void R1(object sender, EventArgs e)
        {
            await DisplayAlert("Отличная работа!","+1LVL", "Ok");
        }
    }
    
}