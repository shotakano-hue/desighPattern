using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    /// <summary>
    /// 本棚オブジェクトを逆方向にスキャンするイテレータ
    /// </summary>
    public class BookShelfInverseIterator : Iterator
    {
        /// <summary>
        /// スキャン対象の本棚オブジェクト
        /// </summary>
        private BookShelf bookShelf;

        /// <summary>
        /// 参照
        /// </summary>
        private int index;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="bookShelf">本棚オブジェクト</param>
        public BookShelfInverseIterator(BookShelf bookShelf)
        {
            this.bookShelf = bookShelf;
            index = bookShelf.getLength() - 1;
        }

        /// <summary>
        /// 次の要素があるか確認する
        /// </summary>
        /// <returns>次の要素が存在するか</returns>
        public bool hasNext()
        {
            if (index >= 0)
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
        /// <returns>本オブジェクト</returns>
        public object next()
        {
            Book book = bookShelf.getBookAt(index);
            index--;
            return book;
        }
    }
}
