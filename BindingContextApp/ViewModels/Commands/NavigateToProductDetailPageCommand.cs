using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace BindingContextApp.ViewModels.Commands
{
    public class NavigateToProductDetailPageCommand : ICommand
    {
        public NavigateToProductDetailPageCommand()
        {
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            Application.Current.MainPage.Navigation.PushAsync(new Views.ProductDetailPage());
        }
    }
}
