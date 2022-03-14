using System.ComponentModel;
using Tarea2_3.ViewModels;
using Xamarin.Forms;

namespace Tarea2_3.Views
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