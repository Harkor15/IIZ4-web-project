using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Shopping_List.Models;

namespace Shopping_List.DAL
{
    public class ShoppingListInitializer :
        System.Data.Entity.DropCreateDatabaseIfModelChanges<ShoppingListContext>
    {
        protected override void Seed(ShoppingListContext context)
        {
            var shoppingLists = new List<ShoppingList>
            {
                new ShoppingList { Name = "First shopping list" },
                new ShoppingList { Name = "Shopping list for tomorow" }
            };
            shoppingLists.ForEach(s => context.ShoppingLists.Add(s));
            context.SaveChanges();
            var shoppingListItems = new List<ShoppingListItem>
            {
                new ShoppingListItem{ ListId=0, Name="Eggs", Checked=false},
                new ShoppingListItem{ ListId=0, Name="Cheese", Checked=false},
                new ShoppingListItem{ ListId=0, Name="Whisky", Checked=true},
                new ShoppingListItem{ ListId=0, Name="Beer", Checked=true},
                new ShoppingListItem{ ListId=0, Name="Bread", Checked=false},
                new ShoppingListItem{ ListId=1, Name="Fish", Checked=false},
                new ShoppingListItem{ ListId=1, Name="Milk", Checked=false},
                new ShoppingListItem{ ListId=1, Name="Chciken", Checked=false},
                new ShoppingListItem{ ListId=1, Name="Tomatoes", Checked=false},
                new ShoppingListItem{ ListId=1, Name="Tea", Checked=false},
                new ShoppingListItem{ ListId=1, Name="Coffee", Checked=false}
            };
            shoppingListItems.ForEach(s => context.ShoppingListItems.Add(s));

            context.SaveChanges();
        }
    }
}