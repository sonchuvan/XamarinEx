using List.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace List
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListEx : ContentPage
    {
        private ObservableCollection<Search> _search;
        private SearchService s = new SearchService();
        ObservableCollection<Search> GetSearches(String searchText = null)
        {
            return new ObservableCollection<Search>
            {
                new Search{Id=1,Location="Ha Noi, Viet Nam", Checkin=new DateTime(2019,12,12), Checkout=new DateTime(2010,1,1)},
                new Search{Id=1,Location="Thai Binh, Viet Nam", Checkin=new DateTime(2019,12,12), Checkout=new DateTime(2010,1,1)},
                new Search{Id=1,Location="Da Nang, Viet Nam", Checkin=new DateTime(2019,12,12), Checkout=new DateTime(2010,1,1)},
                new Search{Id=1,Location="Can Tho, Viet Nam", Checkin=new DateTime(2019,12,12), Checkout=new DateTime(2010,1,1)},
                new Search{Id=1,Location="Ho Chi Minh, Viet Nam", Checkin=new DateTime(2019,12,12), Checkout=new DateTime(2010,1,1)}
            };
            
        }
        public ListEx()
        {
            InitializeComponent();
            
            _search = GetSearches();
            listview.ItemsSource = _search;
        }

        private void listview_Refreshing(object sender, EventArgs e)
        {
            listview.ItemsSource = _search;
            listview.EndRefresh();
        }

        private void Delete_Clicked(object sender, EventArgs e)
        {
            //var search = (sender as MenuItem).CommandParameter as Search;
            s.DeleteSearch((sender as MenuItem).CommandParameter as Search, _search);
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            listview.ItemsSource = s.GetSearches(e.NewTextValue,_search);
        }

        private void listview_ChildRemoved(object sender, ElementEventArgs e)
        {
            
        }
    }
}