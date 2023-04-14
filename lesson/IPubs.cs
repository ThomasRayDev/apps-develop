using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson
{
    internal interface IPubs
    {
        void Subs();
        bool IfSubs { get; set; }
    }
}
