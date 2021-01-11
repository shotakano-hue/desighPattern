using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            BookShelf bookShelf = new BookShelf(4);
            bookShelf.appendBook(new Book("Around the world in 80 days"));
            bookShelf.appendBook(new Book("Bible"));
            bookShelf.appendBook(new Book("Cinderella"));
            bookShelf.appendBook(new Book("Daddy-Long-Legs"));
            Iterator iterator = bookShelf.iterator();
            Iterator invIterator = bookShelf.inverseIterator();

            // 順方向にスキャンする
            while (iterator.hasNext())
            {
                Book book = (Book)iterator.next();
                Console.WriteLine(book.getName());
            }

            // 逆方向にスキャンする
            while (invIterator.hasNext())
            {
                Book book = (Book)invIterator.next();
                Console.WriteLine(book.getName());
            }
        }
    }
}
