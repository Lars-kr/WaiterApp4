using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using WaiterApp4.Models;
using Xamarin.Forms;


namespace WaiterApp4.ViewModels
{
    public class OrderViewModel : ContentView
    {

        //public IList<OrderModel> Order { get; } = new ObservableCollection<OrderModel>();
        public IList<OrderlineModel> Order { get; } = new ObservableCollection<OrderlineModel>();

        //List<OrderlineModel> los = new List<OrderlineModel>();
        public OrderViewModel()
        {
            FillOrder();
        }

        public void FillOrder()
        {


            Order.Add(new OrderlineModel
            {
                Number = "5",
                Price = "14.34",
                Name = "Pepsi"
            });
            Order.Add(new OrderlineModel
            {
                Number = "4",
                Price = "13.34",
                Name = "Coke"
            });


            OrderModel orderM = new OrderModel
            {
                Number = "1405",
               // Orderlines = los,
                OrderDateTime = DateTime.Now.ToString()
            };
            //Order = los;
        }
      

        
    }
}