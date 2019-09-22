using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pathfinder.Shared
{
    public class Code
    {
        public string AlgorithmText { get; set; }
        public bool CanTravelDiagonal { get; set; }
        public int StartCodeLine { get; set; }
        public int CurrentCodeLine { get; set; }
        public bool Initialized { get; set; }
        private List<Line> CodeLines { get; set; }
        public Environment Env { get; set; }

        public Code(string codeText, int start, List<Line> lines)
        {
            AlgorithmText = codeText;
            StartCodeLine = start;
            CurrentCodeLine = StartCodeLine;
            Initialized = false;
            CodeLines = lines;
            Env = new Environment(start);
        }

        public void Setup(bool diagonal, int startX, int startY, int endX, int endY)
        {
            CanTravelDiagonal = diagonal;
            Env.CornersOn = diagonal;
            Env.StartX = startX;
            Env.StartY = startY;
            Env.EndX = endX;
            Env.EndY = endY;
            Initialized = true;
        }
        
        public string[] TextLines => AlgorithmText.Split("\n".ToCharArray());

        public int GetNextLine()
        {
            return Env.NextLine;
        }

        public List<List<Tile>> RunLine(List<List<Tile>> Tiles)
        {
            Env.CreateNodes(Tiles);
            Console.WriteLine(Env.NextLine.ToString());
            Env = CodeLines[CurrentCodeLine].Function(Env);
            CurrentCodeLine = GetNextLine();
            
            Tiles = new List<List<Tile>>();
            for (int i = 0; i < Env.Nodes.Count; i++)
            {
                Tiles.Add(new List<Tile>());
                for (int j = 0; j < Env.Nodes[0].Count; j++)
                {
                    Tiles[i].Add(new Tile(Env.Nodes[i][j].IsWall, Env.Nodes[i][j].IsStart, Env.Nodes[i][j].IsEnd, Env.Nodes[i][j].Discovered));
                }
            }
            return Tiles;
        }
    }
}
