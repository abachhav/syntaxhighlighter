using System;

namespace src
{
    public class Highlighter
    {
        public string[] Keywords {get; set;}

        public Highlighter()
        {
            Keywords = new string[] {"as", "If", "and", "then", "when"};
        }

        public string FindAndHighlight(string input)
        {
            foreach(var keyword in Keywords)
            {
                input = input.Replace(keyword, "[blue]" + keyword + "[blue]");
            }

            return input;
        }
    }
}
