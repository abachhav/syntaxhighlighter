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
                var word = keyword.Split(':')[0];
                var color = keyword.Split(':')[1];
                input = input.Replace(word, "[" + color + "]" + word + "[" + color + "]");
            }

            return input;
        }
    }
}
