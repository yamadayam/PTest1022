using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTest1022 {
    class Book {
        public string Title { get; set; }   //タイトル
        public int Price { get; set; }  //金額
        public int Pages { get; set; }  //ページ
    }

    class Books {
        public List<Book> GetBooks() {
            var books = new List<Book> {
               new Book { Title = "こころ", Price = 800, Pages = 378 },
               new Book { Title = "人間失格", Price = 1200, Pages = 212 },
               new Book { Title = "伊豆の踊子", Price = 1500, Pages = 201 },
               new Book { Title = "若草物語", Price = 1201, Pages = 464 },
               new Book { Title = "銀河鉄道の夜", Price = 2300, Pages = 276 },
               new Book { Title = "二都物語", Price = 1199, Pages = 666 },
               new Book { Title = "遠野物語", Price = 1420, Pages = 268 },
            };
            return books;

        }
    }
}
