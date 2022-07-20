using System.ComponentModel;
using Xamarin.Forms;
using SocialBingo.ViewModels;

namespace SocialBingo.Views
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
