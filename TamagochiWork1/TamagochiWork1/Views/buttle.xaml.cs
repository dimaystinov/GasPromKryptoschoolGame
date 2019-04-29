
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
namespace TamagochiWork1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class buttle : ContentPage
	{
		public buttle ()
		{
            LLL.Text = "" +olvl;

            InitializeComponent ();
		}

        public int olvl { get; }
    }
}