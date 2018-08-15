using SimpleLV.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SimpleLV.View
{
	public partial class ItemListPage : ContentPage
	{
        ItemListController itemListController;

        public ItemListPage()
        {
            InitializeComponent();
            itemListController = new ItemListController();
            BindingContext = itemListController;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await itemListController.UpdatePostsAsync();
        }
    }
}