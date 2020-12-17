using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SwipeViewItemUpdateBug
{
    public partial class MainPage : ContentPage
    {
        private List<SwipeView> swipedItems = new List<SwipeView>();
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = new ItemViewModel();
        }
    }
}
