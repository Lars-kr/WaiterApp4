using System;
using System.Collections.Generic;
using System.Text;

namespace WaiterApp4.Models
{
    public class ItemModel
    {
        public string Name { get; set; }
        public string Price { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public bool Favorites { get; set; }
    }
}
