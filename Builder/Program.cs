using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                usage();
                goto FINISH;
            }
            if (args[0].Equals("plain"))
            {
                TextBuilder textBuilder = new TextBuilder();
                Director director = new Director(textBuilder);
                director.construct();
                string result = textBuilder.getResult();
                Console.WriteLine(result);
            }
            else if(args[0].Equals("html"))
            {

            }
            else
            {
                usage();
            }

        FINISH:
            return;
        }

        /// <summary>
        /// 使用方法を表示
        /// </summary>
        public static void usage()
        {
            Console.WriteLine("Usage : C# Main plain");
            Console.WriteLine("Usage : C# Main html");
        }
    }
}
