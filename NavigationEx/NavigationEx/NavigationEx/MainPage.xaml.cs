using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NavigationEx
{
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
            listview.ItemsSource = new List<FriendList>
            {
                new FriendList{ ImgUrl="dog5.jpg",Name="Dog 5",Activities="Woof woof Woof woof x5",FriendProfile="Hi I am Dog 5, nice to meet you !"},
                new FriendList{ ImgUrl="dog6.jpg",Name="Dog 6",Activities="Woof woof Woof woof x6",FriendProfile="Hi I am Dog 6, nice to meet you !"},
                new FriendList{ ImgUrl="dog7.jpg",Name="Dog 7",Activities="Woof woof Woof woof x7",FriendProfile="Hi I am Dog 7, nice to meet you !"},
                new FriendList{ ImgUrl="cat1.jpg",Name="Cat 1",Activities="Meow meow meow x1",FriendProfile="Hi I am Cat 1, nice to meet you !"},
                new FriendList{ ImgUrl="cat2.jpg",Name="Cat 2",Activities="Meow meow meow x2",FriendProfile="Hi I am Cat 2, nice to meet you !"},
                new FriendList{ ImgUrl="cat3.jpg",Name="Cat 3",Activities="Meow meow meow x3",FriendProfile="Hi I am Cat 3, nice to meet you !"},
                new FriendList{ ImgUrl="dog1.jpg",Name="Dog 1",Activities="Woof woof Woof woof x1",FriendProfile="Hi I am Dog 1, nice to meet you !"},
                new FriendList{ ImgUrl="dog2.jpg",Name="Dog 2",Activities="Woof woof Woof woof x2",FriendProfile="Hi I am Dog 2"},
                new FriendList{ ImgUrl="dog3.jpg",Name="Dog 3",Activities="Woof woof Woof woof x3",FriendProfile="Hi I am Dog 3"},
                new FriendList{ ImgUrl="dog4.jpg",Name="Dog 4",Activities="Woof woof Woof woof x4",FriendProfile="Hi I am Dog 4"},
                new FriendList{ ImgUrl="cat3.jpg",Name="Cat 3",Activities="Meow meow meow x3",FriendProfile="Hi I am Cat 3, nice to meet you !"},
                new FriendList{ ImgUrl="dog1.jpg",Name="Dog 1",Activities="Woof woof Woof woof x1",FriendProfile="Hi I am Dog 1, nice to meet you !"},
                new FriendList{ ImgUrl="dog2.jpg",Name="Dog 2",Activities="Woof woof Woof woof x2",FriendProfile="Hi I am Dog 2"},
                new FriendList{ ImgUrl="dog3.jpg",Name="Dog 3",Activities="Woof woof Woof woof x3",FriendProfile="Hi I am Dog 3"},
                new FriendList{ ImgUrl="dog4.jpg",Name="Dog 4",Activities="Woof woof Woof woof x4",FriendProfile="Hi I am Dog 4"},
                new FriendList{ ImgUrl="cat3.jpg",Name="Cat 3",Activities="Meow meow meow x3",FriendProfile="Hi I am Cat 3, nice to meet you !"},
                new FriendList{ ImgUrl="dog1.jpg",Name="Dog 1",Activities="Woof woof Woof woof x1",FriendProfile="Hi I am Dog 1, nice to meet you !"},
                new FriendList{ ImgUrl="dog2.jpg",Name="Dog 2",Activities="Woof woof Woof woof x2",FriendProfile="Hi I am Dog 2"},
                new FriendList{ ImgUrl="dog3.jpg",Name="Dog 3",Activities="Woof woof Woof woof x3",FriendProfile="Hi I am Dog 3"},
                new FriendList{ ImgUrl="dog4.jpg",Name="Dog 4",Activities="Woof woof Woof woof x4",FriendProfile="Hi I am Dog 4"},

            };
        }

        private async void listview_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if(e.SelectedItem == null)
            {
                return;
            }

            var friend = e.SelectedItem as FriendList;
            await Navigation.PushAsync(new ProfilePage(friend));
            listview.SelectedItem = null;
        }
    }
}
