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
                new ItemModel(){Title = "item 3" , Count=3},
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
