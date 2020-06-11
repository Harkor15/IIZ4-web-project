using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shopping_List.Models
{
    public class ShoppingLists
    {
        public int ID { get; set; }
        public List<string> items { get; set; }
        public string name { get; set; }
    }

}