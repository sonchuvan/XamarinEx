using List.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace List
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailSearch : ContentPage
    {
        public DetailSearch(Search search)
        {
            if (search == null)
                throw new ArgumentException();
            BindingContext = search;
            InitializeComponent();
        }
    }
}