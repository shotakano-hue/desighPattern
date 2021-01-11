using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    /// <summary>
    /// 本棚オブジェクト
    /// </summary>
    public class BookShelf : Aggregate
    {
        /// <summary>
        /// Bookオブジェクトの集合体
        /// </summary>
        private Book[] books;

        /// <summary>
        /// 集合体に格納されている本の数
        /// </summary>
        private int last = 0;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="maxsize">集合体の最大要素数</param>
        public BookShelf(int maxsize)
        {
            this.books = new Book[maxsize];
        }

        /// <summary>
        /// 指定インデックスの本オブジェクトを取得する
        /// </summary>
        /// <param name="index">本オブジェクト</param>
        /// <returns></returns>
        public Book getBookAt(int index)
        {
            return books[index];
        }

        /// <summary>
        /// 本棚に本を追加する
        /// </summary>
        /// <param name="book">本オブジェクト</param>
        public void appendBook(Book book)
        {
            books[last] = book;
            last++;
        }
        
        /// <summary>
        /// 格納されている本オブジェクトの数を返す
        /// </summary>
        /// <returns>本オブジェクトの数</returns>
        public int getLength()
        {
            return last;
        }

        /// <summary>
        /// 本棚オブジェクトのイテレータを返す(順方向)
        /// </summary>
        /// <returns>本棚オブジェクトのイテレータ</returns>
        public Iterator iterator()
        {
            return new BookShelfIterator(this);
        }

        /// <summary>
        /// 本棚オブジェクトのイテレータを返す(逆方向)
        /// </summary>
        /// <returns>本棚オブジェクトのイテレータ(逆方向)</returns>
        public Iterator inverseIterator()
        {
            return new BookShelfInverseIterator(this);
        }
    }
}
