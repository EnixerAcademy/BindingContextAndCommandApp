using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace BindingContextApp.ViewModels
{
    public class ProductDetailViewModels : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ProductDetailViewModels()
        {
        }

        private Models.Product product;
        public Models.Product Product
        {
            get
            {
                return product;
            }
            set
            {
                product = value;
                OnPropertyChanged(nameof(Product));
            }
        }

        protected void OnPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
