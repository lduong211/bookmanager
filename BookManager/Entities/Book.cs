using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManager.Entities
{
    class Book : IBook  
    {
        private ArrayList chapters = new ArrayList();

        public string this[int index]
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public string Title{ get; set; }

        public string Author{ get; set; }

        public string Publisher { get; set; }

        public string ISBN { get; set; }

        public string year { get; set; }
        //input info
        void input()
        {
            Console.WriteLine("Title:");
            Title=Console.ReadLine();
            Console.WriteLine("Author:");
            Title = Console.ReadLine();
            Console.WriteLine("Publisher:");
            Title = Console.ReadLine();
            Console.WriteLine("ISBN:");
            Title = Console.ReadLine();
            Console.WriteLine("Year:");
            Title = Console.ReadLine();
            Console.WriteLine("Chapter:");
            string str;
            int i = 0;
            //if chapter is not null -> continue, else break
            do
            {
                Console.WriteLine("Chapter[0]'s name:", i + 1);
                str = Console.ReadLine();
                if (str.Length > 0)
                {
                    chapters[i] = str;
                    i++;
                }
            } while (str.Length > 0);
        }
        //show info
        void show()
        {
            Console.WriteLine("Title:");
            Console.WriteLine("Author:");
            Console.WriteLine("Publisher:");
            Console.WriteLine("ISBN:");
            Console.WriteLine("Year:");
            foreach (var item in chapters)
                Console.WriteLine(item);
        }
    }
}
