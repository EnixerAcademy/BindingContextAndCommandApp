using System;
using Xamarin.Forms;

namespace BindingContextApp.ViewModels
{
    public class ProductDetailViewModels
    {
        public ProductDetailViewModels()
        {
            if (!Application.Current.Properties.ContainsKey("productId"))
            {
                Application.Current.MainPage.Navigation.PopAsync();
            }
            ProductId = (int)Application.Current.Properties["productId"];
        }

        private int productId;
        public int ProductId
        {
            get
            {
                return productId;
            }
            set
            {
                productId = value;
            }
        }
    }
}
