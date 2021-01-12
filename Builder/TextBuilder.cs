using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    /// <summary>
    /// プレーンテキストを使用して文書を作成する
    /// </summary>
    public class TextBuilder : Builder
    {
        /// <summary>
        /// プレーンテキスト用のバッファー
        /// </summary>
        private StringBuilder buffer = new StringBuilder();

        /// <summary>
        /// プレーンテキストでのタイトル
        /// </summary>
        /// <param name="title">タイトル</param>
        public override void makeTitle(string title)
        {
            buffer.Append("=============================\n");
            buffer.Append("「" + title + "」\n");
            buffer.Append("\n");
        }

        /// <summary>
        /// プレーンテキストでの文字列
        /// </summary>
        /// <param name="str">文字列</param>
        public override void makeString(string str)
        {
            buffer.Append("■" + str + "\n");
            buffer.Append("\n");
        }

        /// <summary>
        /// プレーンテキストでの箇条書き
        /// </summary>
        /// <param name="items">文字列の配列</param>
        public override void makeItems(string[] items)
        {
            for (int i = 0; i < items.Length; i++)
            {
                buffer.Append(" ・" + items[i] + "\n");
            }
            buffer.Append("\n");
        }

        /// <summary>
        /// 文書の完成
        /// </summary>
        public override void close()
        {
            buffer.Append("=============================\n");
        }

        /// <summary>
        /// 完成した文書を返す
        /// </summary>
        /// <returns>完成した文書</returns>
        public string getResult()
        {
            return buffer.ToString();
        }
    }
}
