using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PickerUpdateSample
{
    public partial class MainPage : ContentPage
    {
        private ViewModel vm;

        public MainPage()
        {
            InitializeComponent();

            vm = new ViewModel();
            this.BindingContext = vm;

            // show the first item, just to make the issue clearer
            thePicker.SelectedIndex = 0;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

            vm.MyItems[0].MyItemName = "New Random Name:" + RandomString(6);
            ResultsLabel.IsVisible = true;

        }

        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
