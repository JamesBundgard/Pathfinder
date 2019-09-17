using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pathfinder.Shared
{
    public class Code
    {
        public string Text { get; set; }
        public int StartLine { get; set; }
        public int CurrentLine { get; set; }

        public Code(string codeText, int start)
        {
            Text = codeText;
            StartLine = start;
            CurrentLine = StartLine;
        }
        
        public string[] Lines => Text.Split("\n".ToCharArray());

        public int GetNextLine()
        {
            if (CurrentLine == Lines.Length - 1) return CurrentLine;
            while (string.IsNullOrWhiteSpace(Lines[++CurrentLine]) || Lines[CurrentLine].TrimStart().StartsWith("//"))
            {
                continue;
            }
            return CurrentLine;
        }
    }
}
