using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Image
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ImageEx : ContentPage
    {
        int count = 1;
        public ImageEx()
        {
            InitializeComponent();

           

            img.Source = "a" + count + ".jpg";
            pt.Text = "Picture: " + count;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (count < 2)
            {
                count = 10;
            }
            else count--;
            img.Source = "a" + count + ".jpg";
            pt.Text = "Picture: " + count;
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            if (count >9)
            {
                count = 1;
            }
            else count++;
            img.Source = "a" + count + ".jpg";
            pt.Text = "Picture: " + count;
        }
    }
}