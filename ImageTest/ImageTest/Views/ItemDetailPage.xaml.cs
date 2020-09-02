using System.ComponentModel;
using Xamarin.Forms;
using ImageTest.ViewModels;

namespace ImageTest.Views
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