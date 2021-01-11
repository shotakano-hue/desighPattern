using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    /// <summary>
    /// 文字列を表示するインターフェース
    /// </summary>
    public interface Print
    {
        /// <summary>
        /// 文字列を表示する
        /// </summary>
        void printWeak();

        /// <summary>
        /// 文字列を強調して表示する
        /// </summary>
        void printStrong();
    }
}
