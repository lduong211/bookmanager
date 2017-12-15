using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookManager.Entities;
using System.Collections;

namespace BookManager.App
{
    class BookList
    {
        private ArrayList books = new ArrayList();
        private Book newbook;

        public void input(int amount)
        {
            for(int i=0 ; i < amount ;i++)
            {
                newbook = new Book();
                newbook.input();
                books.Add(newbook);
            }
        }

        public void output()
        {
            foreach (Book book in books)
            {
                Console.WriteLine("---------");
                book.show();
            }
         }
    }
}
