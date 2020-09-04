using List.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Xamarin.Essentials;

namespace List
{
    public class SearchService
    {
        public IEnumerable<Search> GetSearches(String filter, System.Collections.ObjectModel.ObservableCollection<Search> searches)
        {
            if (String.IsNullOrWhiteSpace(filter))
            {
                return searches;
            }
            else { }
            return searches.Where(f => f.Location.ToLower().Contains(filter.ToLower()));


        }
        public void DeleteSearch(Search searchId, ObservableCollection<Search> searches)
        {
            searches.Remove(searchId);
        }

    }
}
