using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BindingContextApp.Views
{
    public partial class ProductDetailPage : ContentPage
    {
        public ProductDetailPage(Models.Product product)
        {
            InitializeComponent();

            //((ViewModels.ProductDetailViewModels)BindingContext).Product = product;

            (BindingContext as ViewModels.ProductDetailViewModels).Product = product;
        }
    }
}
