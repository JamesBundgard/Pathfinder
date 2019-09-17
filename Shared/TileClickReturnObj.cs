using Microsoft.AspNetCore.Components.Web;

namespace Pathfinder.Shared
{
    public class TileClickReturnObj
    {
        public int Row { get; set; }
        public int Col { get; set; }
        public MouseEventArgs Event { get; set; }

        public TileClickReturnObj(MouseEventArgs e, int i, int j)
        {
            Row = i;
            Col = j;
            Event = e;
        }
    }
}
