using System;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;

namespace BindingContextApp.ViewModels
{
    public class ListProductPageViewModel
    {
        public ListProductPageViewModel()
        {
            Products = new List<Models.Product>()
            {
                new Models.Product()
                {
                    ProductId = 1,
                    ProductName = "Product 1",
                    ProductPrice = 100
                },new Models.Product()
                {
                    ProductId = 2,
                    ProductName = "Product 2",
                    ProductPrice = 100
                },new Models.Product()
                {
                    ProductId = 3,
                    ProductName = "Product 3",
                    ProductPrice = 100
                },new Models.Product()
                {
                    ProductId = 4,
                    ProductName = "Product 4",
                    ProductPrice = 100
                },new Models.Product()
                {
                    ProductId = 5,
                    ProductName = "Product 5",
                    ProductPrice = 100
                },new Models.Product()
                {
                    ProductId = 6,
                    ProductName = "Product 6",
                    ProductPrice = 100
                },new Models.Product()
                {
                    ProductId = 7,
                    ProductName = "Product 7",
                    ProductPrice = 100
                }
            };

            NavigateToProductDetailPageCommand = new Command<int>(NavigateToProductDetailPage, CanExecNavigateToProductDetailPage);

        }

        private List<Models.Product> products;
        public List<Models.Product> Products
        {
            get
            {
                return products;
            }
            set
            {
                products = value;
            }
        }

        public ICommand NavigateToProductDetailPageCommand { get; set; }

        private async void NavigateToProductDetailPage(int productId)
        {
            Application.Current.Properties["productId"] = productId;
            await Application.Current.MainPage.Navigation.PushAsync(new Views.ProductDetailPage());
        }

        private bool CanExecNavigateToProductDetailPage(int productId)
        {
            return true;
        }
    }
}
