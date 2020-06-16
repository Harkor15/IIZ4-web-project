using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shopping_List.Models
{
    public class ShoppingListItem
    {
        public int ID { get; set; }
        public int ListId { get; set; }
        public string Name { get; set; }
        public bool Checked { get; set; }
    }
}