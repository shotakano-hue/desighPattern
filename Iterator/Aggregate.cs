using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    /// <summary>
    /// 集約体を表すインターフェース
    /// </summary>
    public interface Aggregate
    {
        Iterator iterator();  
    }
}
