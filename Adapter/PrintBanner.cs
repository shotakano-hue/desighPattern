using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    /// <summary>
    /// アダプターオブジェクト
    /// </summary>
    public class PrintBanner : Banner ,Print
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="str">文字列</param>
        public PrintBanner(string str) : base(str)
        {
        }

        /// <summary>
        /// 文字列を協調して表示する
        /// </summary>
        public void printStrong()
        {
            base.showWithAster();
        }

        /// <summary>
        /// 文字列を表示する
        /// </summary>
        public void printWeak()
        {
            base.showWithParen();
        }
    }
}
