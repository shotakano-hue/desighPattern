using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    /// <summary>
    /// 1つの文書を作るクラス
    /// </summary>
    public class Director
    {
        /// <summary>
        /// Buiderのサブクラス
        /// </summary>
        private Builder builder;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="builder">Buiderのサブクラス</param>
        public Director(Builder builder)
        {
            this.builder = builder;
        }

        /// <summary>
        /// 文書を作る
        /// </summary>
        public void construct()
        {
            builder.makeTitle("Greeting");
            builder.makeString("朝から昼にかけて");
            builder.makeItems(new string[] {
                "おはようございます。",
                "こんにちは。"
            });

            builder.makeString("夜に");
            builder.makeItems(new string[] {
                "こんばんは。",
                "おやすみなさい",
                "さようなら。"
            });
            builder.close();
        }
    }
}
