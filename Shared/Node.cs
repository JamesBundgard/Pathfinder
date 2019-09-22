using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pathfinder.Shared
{
    public class Node
    {
        public bool Discovered { get; set; }
        public bool IsWall { get; set; }
        public bool IsStart { get; set; }
        public bool IsEnd { get; set; }
        public int Y { get; set; }
        public int X { get; set; }
        public Node Parent { get; set; }

        public Node(bool wall = false, bool start = false, bool end = false, bool disc = false)
        {
            Discovered = disc;
            IsWall = wall;
            IsStart = start;
            IsEnd = end;
        }
    }
}
