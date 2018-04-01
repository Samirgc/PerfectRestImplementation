using ListView_Sample.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListView_Sample
{
	public partial class MainPage : ContentPage
	{

        public static string RestUrl = "https://jsonplaceholder.typicode.com/photos";

      



        public MainPage()
		{
			InitializeComponent();
		}









        protected async override void OnAppearing()
        {
            base.OnAppearing();

            myListView.ItemsSource = await App.MYitemsManager.GetTasksAsync();
           // await DisplayAlert("done", "yes" + (myListView.ItemsSource as List<Item>).Count, "ok");
        }
        //void Event_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        //{
        //    DisplayAlert("Selected item", "you selected the Item ( " + (e.SelectedItem as Item).title + " )", "ok");
        //}
    }
}
