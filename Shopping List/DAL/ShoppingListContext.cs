using Shopping_List.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Shopping_List.DAL
{
    public class ShoppingListContext : DbContext
    {
        public ShoppingListContext() : base("ShoppingListContext")
        {
        }

        public DbSet<ShoppingLists> ShoppingLists { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}