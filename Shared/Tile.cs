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

        public Tile()
        {
            IsEndPoint = false;
            IsStartPoint = false;
            IsWall = false;
        }

        public void ToggleStartPoint() => IsStartPoint = !IsStartPoint;
        public void ToggleEndPoint() => IsEndPoint = !IsEndPoint;
        public void ToggleWall() => IsWall = !IsWall;
    }
}
