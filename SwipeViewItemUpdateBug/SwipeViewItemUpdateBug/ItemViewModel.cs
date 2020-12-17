using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace SwipeViewItemUpdateBug
{
    class ItemViewModel : INotifyPropertyChanged
    {

        public ObservableCollection<ItemModel> Items { get; private set; } = new ObservableCollection<ItemModel>();

        public ICommand IncrementCommand => new Command<ItemModel>(Increment);
        public ICommand DecrementCommand => new Command<ItemModel>(Decrement);


        public ItemViewModel()
        {
            Items = new ObservableCollection<ItemModel>
            {
                new ItemModel(){Title = "item 1" , Count=2},
                new ItemModel(){Title = "item 2" , Count=5},
                new ItemModel(){Title = "item 3" , Count=5},
                new ItemModel(){Title = "item 4" , Count=7},
                new ItemModel(){Title = "item 5" , Count=2},
                new ItemModel(){Title = "item 6" , Count=9},
                new ItemModel(){Title = "item 7" , Count=6},
                new ItemModel(){Title = "item 8" , Count=5},
                new ItemModel(){Title = "item 9" , Count=8},
                new ItemModel(){Title = "item 10" , Count=2},
                new ItemModel(){Title = "item 11" , Count=5},
                new ItemModel(){Title = "item 12" , Count=1},
                new ItemModel(){Title = "item 13" , Count=7},
                new ItemModel(){Title = "item 14" , Count=3},
                new ItemModel(){Title = "item 15" , Count=8},
                new ItemModel(){Title = "item 16" , Count=7},
                new ItemModel(){Title = "item 17" , Count=5},
                new ItemModel(){Title = "item 18" , Count=2},
                new ItemModel(){Title = "item 19" , Count=8},
                new ItemModel(){Title = "item 20" , Count=4}
            };
        }

        public void Increment(ItemModel item)
        {
            item.Count++;
        }
        public void Decrement(ItemModel item)
        {
            item.Count--;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
