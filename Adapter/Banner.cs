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
    public class Banner
    {
        /// <summary>
        /// 文字列
        /// </summary>
        private string str;
        
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="str">文字列</param>
        public Banner(string str)
        {
            this.str = str;
        }

        /// <summary>
        /// 文字列を()付きで表示する
        /// </summary>
        public void showWithParen()
        {
            Console.WriteLine("({0})", str);
        }

        /// <summary>
        /// 文字列を*付きで表示する
        /// </summary>
        public void showWithAster()
        {
            Console.WriteLine("*{0}*", str);
        }
    }
}
