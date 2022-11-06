using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
//using static Android.Content.ClipData;

namespace ShoppingUI
{
    public class HomeViewModel
    {
        public ObservableCollection<Items> Items { get; set; }

        //public Items SelectedItem { get; set; }

        //public ICommand CarouselClick { get; set; }

        public HomeViewModel(INavigation navigation)
        {
            Items = new ObservableCollection<Items>
            {
                new Items
                {
                    Picture="wristwatch.png",
                    Name = "Wrist Watch",
                    Quantity = "1",
                    Price = "$85"
                },
                new Items
                {
                    Picture="militarywatch.png",
                    Name = "Army Watch",
                    Quantity = "1",
                    Price = "$99"
                }
            };

            //CarouselClick = new Command<Items>(onCarouselClick);
        }

        //private INavigation navigation;

        //async void onCarouselClick(Items item)
        //{
        //    this.SelectedItem = item;
        //    await navigation.PushModalAsync(new DetailsPage(this));
        //}
    }
}
