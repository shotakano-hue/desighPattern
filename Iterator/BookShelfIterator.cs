using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    /// <summary>
    /// 本棚オブジェクトをスキャンするクラス
    /// </summary>
    public class BookShelfIterator : Iterator
    {
        /// <summary>
        /// スキャン対象のオブジェクト
        /// </summary>
        private BookShelf bookShelf;

        /// <summary>
        ///イテレータの参照場所
        /// </summary>
        private int index;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="bookShelf">スキャン対象の本棚オブジェクト</param>
        public BookShelfIterator(BookShelf bookShelf)
        {
            this.bookShelf = bookShelf;
            index = 0;
        }

        /// <summary>
        /// スキャン対象が次の要素を持っているか
        /// </summary>
        /// <returns>持っているかどうか</returns>
        public bool hasNext()
        {
            if (index < bookShelf.getLength())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 集合体から次の要素を取得する
        /// </summary>
        /// <returns>集合体の要素</returns>
        public object next()
        {
            Book book = bookShelf.getBookAt(index);
            index++;
            return book;
        }
    }
}
