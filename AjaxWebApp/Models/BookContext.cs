﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Data.Entity;

namespace AjaxWebApp.Models
{
    public class BookContext : DbContext
    {
        public DbSet <Book> Books { get; set; }
    }

    public class BookDbInitializer : DropCreateDatabaseAlways<BookContext>
    {
        protected override void Seed(BookContext db)
        {
            db.Books.Add(new Book { Name = "Война и мир", Author = "Л. Толстой" });
            db.Books.Add(new Book { Name = "Воскресенье", Author = "Л. Толстой" });
            db.Books.Add(new Book { Name = "Крейцерова Соната", Author = "Л. Толстой" });
            db.Books.Add(new Book { Name = "Отцы и дети", Author = "И. Тургенев" });
            db.Books.Add(new Book { Name = "Рудин", Author = "И. Тургенев" });
            db.Books.Add(new Book { Name = "Накануне", Author = "И. Тургенев" });
            db.Books.Add(new Book { Name = "Чайка", Author = "А. Чехов" });

            base.Seed(db);
        }
    }
}