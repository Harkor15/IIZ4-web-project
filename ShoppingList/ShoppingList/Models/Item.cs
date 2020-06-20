using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingList.Models
{
    public class Item
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool Checked { get; set; }
        public int ListID { get; set; }
        public virtual List List { get; set; }
    }
}