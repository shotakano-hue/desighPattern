using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Print p = new PrintBanner("Hello");
            p.printWeak();
            p.printStrong();

            Print_delegate p2 = new PrintBanner_delegate("Hello2");
            p2.printWeak();
            p2.printStrong();
        }
    }
}
