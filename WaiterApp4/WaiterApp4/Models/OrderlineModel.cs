using System;
using System.Collections.Generic;
using System.Text;

namespace WaiterApp4.Models
{
    public class OrderlineModel
    {
        public string Name { get; set; }
        public string Number { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }

        public string FullOrderline
        {
            get { return string.Format("{0}x {1} {2}", Number, Name, (Double.Parse(Price) * Int32.Parse(Number)).ToString()); }
        }
    }
}
