using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using WaiterApp4.Models;
using Xamarin.Forms;

namespace WaiterApp4.ViewModels
{
    public class MenuViewModel : ContentView
    {
        public IList<ItemModel> MenuCol { get; } = new ObservableCollection<ItemModel>();

        public MenuViewModel()
        {
            FillMenu();
        }

        public void FillMenu()
        {
            ItemModel mit1 = new ItemModel() { Name = "mit1", Image = "img1", Price = "15.99" };
            ItemModel mit2 = new ItemModel() { Name = "mit2", Image = "img2", Price = "12.50" };
            ItemModel mit3 = new ItemModel() { Name = "mit3", Image = "img3", Price = "99.99" };
            ItemModel mit4 = new ItemModel() { Name = "mit4", Image = "img4", Price = "12.32" };
            ItemModel mit5 = new ItemModel() { Name = "mit5", Image = "img5", Price = "199.99" };
            ItemModel mit6 = new ItemModel() { Name = "mit6", Image = "img6", Price = "122.32" };
            ItemModel mit7 = new ItemModel() { Name = "mit7", Image = "img7", Price = "134.32" };
            ItemModel mit8 = new ItemModel() { Name = "mit8", Image = "img8", Price = "11.99" };
            ItemModel mit9 = new ItemModel() { Name = "mit9", Image = "img9", Price = "63.22" };
            MenuCol.Add(mit1);
            MenuCol.Add(mit2);
            MenuCol.Add(mit3);
            MenuCol.Add(mit4);
            MenuCol.Add(mit5);
            MenuCol.Add(mit6);
            MenuCol.Add(mit7);
            MenuCol.Add(mit8);
            MenuCol.Add(mit9);
        }
    }
}
