using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FormAndSetting
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddressList : ContentPage
    {
        public AddressList()
        {
            InitializeComponent();
            listview.ItemsSource = new List<String>
            {
                "Ha Noi",
                "Hai Phong",
                "Thai Binh",
                "Ho Chi Minh",
                "Can Tho"
            };
        }
        public ListView address { get { return listview; } }
    }
}