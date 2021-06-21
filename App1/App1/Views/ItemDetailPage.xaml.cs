using App1.ViewModels;
using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace App1.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }

        void OnButtonClicked(object sender, EventArgs args)
        {
            label.IsVisible = true;
        }
    }
}