using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManager.App
{
    class AppBookManager
    {
        private BookList booklist = new BookList();
        public void run()
        {
            int chon ;
            do
            {
                Console.WriteLine("1.Nhap danh sach sach");
                Console.WriteLine("2.Xuat danh sach sach");
                Console.WriteLine("3.Thoat");
                Console.WriteLine("Chon:");
                chon = int.Parse(Console.ReadLine());

                switch(chon){
                    case 1:
                        Console.WriteLine("Nhap so luong sach:");
                        int sl = int.Parse(Console.ReadLine());
                        booklist.input(sl);
                        break;
                    case 2:
                        booklist.output();
                        break;
                    default:
                        break;
                }
            } while (true);
        }
    }
}
