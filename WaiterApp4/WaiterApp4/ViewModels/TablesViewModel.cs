using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using WaiterApp4.Models;
using Xamarin.Forms;

namespace WaiterApp4.ViewModels
{
    public class TablesViewModel : ContentView
    {

        public IList<TableModel> Tables { get; } = new ObservableCollection<TableModel>();
        public TablesViewModel()
        {
            FillTables();
        }

        public void FillTables()
        {
            for (int i = 1; i< 30; i++)
            {
                TableModel tb = new TableModel()
                {
                    TableNumber = i.ToString(),
                    TableOrder = new OrderModel()
                };

                Tables.Add(tb);
            }
}
    }
}