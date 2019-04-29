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
	public partial class Team : ContentPage
	{
        private async void T1(object sender, EventArgs e)
        {
            await DisplayAlert("Профиль пользователя:", "Уровень: 12; Здоровье: 34; Сила: 67; Ловкость: 22; Интелект: 52; ", "Ok");
        }
        private async void T2(object sender, EventArgs e)
        {
            await DisplayAlert("Профиль пользователя:", "Уровень: 85; Здоровье: 45; Сила: 232; Ловкость: 72; Интелект: 32; ", "Ok");
        }
        private async void T3(object sender, EventArgs e)
        {
            await DisplayAlert("Профиль пользователя:", "Уровень: 10; Здоровье: 8; Сила: 5; Ловкость: 9; Интелект: 12; ", "Ok");
        }
    }
}