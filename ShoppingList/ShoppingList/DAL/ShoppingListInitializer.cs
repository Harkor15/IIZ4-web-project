using ShoppingList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingList.DAL
{
    public class ShoppingListInitializer:
        System.Data.Entity.DropCreateDatabaseIfModelChanges<ShoppingListContext>
    {
        protected override void Seed(ShoppingListContext context)
        {
            var shoppingLists = new List<List>
            {
                new List { Name = "First shopping list" },
                new List { Name = "Shopping list for tomorow" }
            };
            shoppingLists.ForEach(s => context.Lists.Add(s));
            context.SaveChanges();
            var shoppingListItems = new List<Item>
            {
                new Item{ ListId=0, Name="Eggs", Checked=false},
                new Item{ ListId=0, Name="Cheese", Checked=false},
                new Item{ ListId=0, Name="Whisky", Checked=true},
                new Item{ ListId=0, Name="Beer", Checked=true},
                new Item{ ListId=0, Name="Bread", Checked=false},
                new Item{ ListId=1, Name="Fish", Checked=false},
                new Item{ ListId=1, Name="Milk", Checked=false},
                new Item{ ListId=1, Name="Chciken", Checked=false},
                new Item{ ListId=1, Name="Tomatoes", Checked=false},
                new Item{ ListId=1, Name="Tea", Checked=false},
                new Item{ ListId=1, Name="Coffee", Checked=false}
            };
            shoppingListItems.ForEach(s => context.Items.Add(s));

            context.SaveChanges();
            //base.Seed(context);
        }
    }
}