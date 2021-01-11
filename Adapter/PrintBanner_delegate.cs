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
    public class PrintBanner_delegate : Print_delegate
    {
        /// <summary>
        /// 文字列を表示するオブジェクト
        /// </summary>
        private Banner banner;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="str">文字列</param>
        public PrintBanner_delegate(string str)
        {
            this.banner = new Banner(str);
        }

        /// <summary>
        /// 文字列を強調して表示する
        /// </summary>
        public override void printStrong()
        {
            banner.showWithAster();
        }

        /// <summary>
        /// 文字列を表示する
        /// </summary>
        public override void printWeak()
        {
            banner.showWithParen();
        }
    }
}
