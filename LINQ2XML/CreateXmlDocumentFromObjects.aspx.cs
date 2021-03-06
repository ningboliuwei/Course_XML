﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using System.Xml.Linq;

namespace LINQ2XML
{
    public partial class CreateXmlDocumentFromObjects : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnConvert_OnClick(object sender, EventArgs e)
        {
            var books = new List<Book>
            {
                new Book
                {
                    Title = "红楼梦",
                    Genre = "小说",
                    FirstName = "曹",
                    LastName = "雪芹",
                    Price = 9.99
                },
                new Book
                {
                    Title = "西游记",
                    Genre = "小说",
                    FirstName = "吴",
                    LastName = "承恩",
                    Price = 20.13
                },
                new Book
                {
                    Title = "三国演义",
                    Genre = "小说",
                    FirstName = "罗",
                    LastName = "贯中",
                    Price = 30.82
                },
                new Book()
                {
                    Title = "水浒传",
                    Genre = "小说",
                    FirstName = "施",
                    LastName = "耐庵",
                    Price = 15.45
                }
            };

            var xDoc = new XDocument(
                new XDeclaration("1.0", "UTF-8", "yes"),
                new XElement("bookstore",
                    books.Select(
                        b => new XElement("book", new XAttribute("genre", b.Genre),
                            new XElement("title", b.Title),
                            new XElement("author",
                                new XElement("first-name", b.FirstName),
                                new XElement("last-name", b.LastName)),
                            new XElement("price", b.Price)))));

            xDoc?.Save(Server.MapPath("books_4.xml"));
        }

        private class Book
        {
            public string Title { get; set; }
            public string Genre { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public double Price { get; set; }
        }
    }
}