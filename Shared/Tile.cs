using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pathfinder.Shared
{
    public class Tile
    {
        public bool IsEndPoint { get; set; }
        public bool IsStartPoint { get; set; }
        public bool IsWall { get; set; }
        public bool IsDiscovered { get; set; }
        public bool IsBeingLookedAt { get; set; }

        public Tile(bool wall = false, bool start = false, bool end = false, bool disc = false)
        {
            IsEndPoint = end;
            IsStartPoint = start;
            IsWall = wall;
            IsDiscovered = disc;
        }

        public void ToggleStartPoint() => IsStartPoint = !IsStartPoint;
        public void ToggleEndPoint() => IsEndPoint = !IsEndPoint;
        public void ToggleWall() => IsWall = !IsWall;
    }
}
