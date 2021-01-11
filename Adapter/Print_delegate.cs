using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    /// <summary>
    /// 文字列を表示するオブジェクト
    /// </summary>
    public abstract class Print_delegate
    {
        /// <summary>
        /// 文字列を表示する
        /// </summary>
        /// <returns></returns>
        public abstract void printWeak();

        /// <summary>
        /// 文字列を強調して表示する
        /// </summary>
        /// <returns></returns>
        public abstract void printStrong();
    }
}
