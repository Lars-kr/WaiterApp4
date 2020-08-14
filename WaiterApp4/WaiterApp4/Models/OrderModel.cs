using System;
using System.Collections.Generic;
using System.Text;

namespace WaiterApp4.Models
{
    public class OrderModel
    {
        public string Number { get; set; }

        public List<OrderlineModel> Orderlines { get; set; }

        public string OrderDateTime { get; set; }

        public string OrderNumber
        {
            get { return string.Format("Ordernumber: {0}", Number);}
        }

        
    }
   
}
