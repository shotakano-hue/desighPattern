using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    /// <summary>
    /// 数え上げ、スキャンを行うインターフェース
    /// </summary>
    public interface Iterator
    {
        bool hasNext();
        Object next();
    }
}
