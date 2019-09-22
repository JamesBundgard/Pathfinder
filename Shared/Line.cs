using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pathfinder.Shared
{
    public class Line
    {
        public Func<Environment, Environment> Function;

        public Line(Func<Environment, Environment> fun)
        {
            Function = fun;
        }
    }
}
