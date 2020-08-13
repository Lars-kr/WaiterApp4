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

        ObservableCollection<OrderModel> Order = new ObservableCollection<OrderModel>();
        //public ObservableCollection<OrderlineModel> Order{ get { return orderlines; } }
        List<OrderlineModel> los = new List<OrderlineModel>();
        public OrderViewModel()
        {
            FillOrder();
        }

        public void FillOrder()
        {


            los.Add(new OrderlineModel
            {
                Number = "5",
                Price = "14.34",
                Name = "Pepsi"
            });
            los.Add(new OrderlineModel
            {
                Number = "4",
                Price = "13.34",
                Name = "Coke"
            });


            OrderModel orderM = new OrderModel
            {
                Number = "1405",
                Orderlines = los,
                OrderDateTime = DateTime.Now.ToString()
            };
            Order.Add(orderM);
        }
      

        
    }
}