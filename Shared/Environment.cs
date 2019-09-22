using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pathfinder.Shared
{
    public class Environment
    {
        public int NextLine { get; set; }
        public List<int> Ints { get; set; }
        public List<List<Node>> Nodes { get; set; }
        public List<Stack<Node>> StacksOfNodes { get; set; }
        public List<Queue<Node>> QueuesOfNodes { get; set; }
        public List<Node> TempNodes { get; set; }
        public int StartX { get; set; }
        public int StartY { get; set; }
        public int EndX { get; set; }
        public int EndY { get; set; }
        public bool CornersOn { get; set; }

        public Environment (int nextLine, List<int> ints = null, List<Stack<Node>> stacksOfNodes=null)
        {
            NextLine = nextLine;
            Ints = ints ?? new List<int>();
            StacksOfNodes = stacksOfNodes ?? new List<Stack<Node>>();
            QueuesOfNodes = new List<Queue<Node>>();
            Nodes = new List<List<Node>>();
            TempNodes = new List<Node>();
        }

        public void CreateNodes(List<List<Tile>> Tiles)
        {
            Nodes = new List<List<Node>>();
            for (int i = 0; i < Tiles.Count; i++)
            {
                Nodes.Add(new List<Node>());
                for (int j = 0; j < Tiles[0].Count; j++)
                {
                    Nodes[i].Add(new Node(Tiles[i][j].IsWall, Tiles[i][j].IsStartPoint, Tiles[i][j].IsEndPoint, Tiles[i][j].IsDiscovered) { X=j, Y=i});
                }
            }
        }
    }
}
