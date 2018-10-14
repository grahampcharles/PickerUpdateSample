using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace PickerUpdateSample
{
    class ViewModel : BaseViewModel 
    {
        public ObservableCollection<MyItem> MyItems { get; set; }

        public ViewModel()
        {
            MyItems = new ObservableCollection<MyItem>();
            MyItems.Add(new MyItem() { MyItemName = "Item 1" });
            MyItems.Add(new MyItem() { MyItemName = "Item 2" });
            MyItems.Add(new MyItem() { MyItemName = "Item 3" });
        }

        public string FirstItemName
        {
            get { return MyItems[0].MyItemName; }
        }
    }

    class MyItem : ObservableObject
    {
        private string myItemName;
        public string MyItemName { get => myItemName; set => SetProperty(ref myItemName, value); }
    }
}
