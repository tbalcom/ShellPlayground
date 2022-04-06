using Shell_Playground.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Shell_Playground.Views
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