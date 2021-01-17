using System.ComponentModel;
using UCustomMadeMoviesAPP.ViewModels;
using Xamarin.Forms;

namespace UCustomMadeMoviesAPP.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}