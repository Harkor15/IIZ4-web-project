using ShoppingList.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace ShoppingList.DAL
{
    public class ShoppingListContext: DbContext
    {
        public ShoppingListContext(): base ("ShoppingListContext")
        {
        }

        public DbSet<List> Lists { get; set; }

        public DbSet<Item> Items { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}