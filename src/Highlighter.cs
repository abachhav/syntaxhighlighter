using System;

namespace src
{
    public class Highlighter
    {
        private string[] keywords;

        public Highlighter(string[] keywords)
        {
            this.keywords = keywords;
        }

        public string FindAndHighlight(string input)
        {
            foreach(var keyword in keywords)
            {
                input = input.Replace(keyword, "[blue]" + keyword + "[blue]");
            }

            return input;
        }
    }
}
