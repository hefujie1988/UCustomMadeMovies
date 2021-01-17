using System;
using System.Collections.Generic;
using System.ComponentModel;
using UCustomMadeMovies.Models;
using UCustomMadeMovies.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UCustomMadeMovies.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}