using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;



namespace Bookstore
{
    internal class BookStoreContext: DbContext
    {

        public BookStoreContext() : base("DBConnection") {}
        public DbSet<Book> Books { get; set; } = null;
        

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Book>().HasKey(b=>b.Number);
            

        //}

    }
}
