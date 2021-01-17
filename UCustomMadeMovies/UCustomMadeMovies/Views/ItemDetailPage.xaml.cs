using System.ComponentModel;
using UCustomMadeMovies.ViewModels;
using Xamarin.Forms;

namespace UCustomMadeMovies.Views
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