using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    /// <summary>
    /// 本オブジェクト
    /// </summary>
    public class Book
    {
        /// <summary>
        /// 本の名前
        /// </summary>
        private string name;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="name">本の名前</param>
        public Book(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// 本の名前を取得する(プロパティ)
        /// </summary>
        /// <returns>本の名前</returns>
        public string getName()
        {
            return name;
        }
    }
}