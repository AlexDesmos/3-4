using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_4
{
    interface IChoiceEl<P>
    {
        P UserEl();

        P RndEl();
    }
}
