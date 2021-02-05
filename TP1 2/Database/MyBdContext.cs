using System;
using System.Data.Entity;
using TP1.Entities;

namespace TP1.Database
{
    public class MyBdContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Editor> Editors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookShop> BookShops { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Buy> Buys { get; set; }

        public MyBdContext()
        {
            if (this.Database.CreateIfNotExists())
            {
                for (int i =0; i < 2; i++)
                {
                    this.Authors.Add(new Entities.Author() { Firstname = "F" + i, Lastname = "L" + i });
                }

                for (int i = 0; i < 1; i++)
                {
                    this.Editors.Add(new Entities.Editor() { Firstname = "F" + i, Lastname = "L" + i });
                }

                for (int i = 0; i < 10; i++)
                {
                    this.Books.Add(new Entities.Book() { Name = "N" + i, Nb_page = "N" + i});
                }
            }
        }
    }
}
