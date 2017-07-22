using System;
using System.Collections.Generic;

namespace src
{
    public class Keyword
    {
        public string Word { get; set; }
        public string Color { get; set; }
        public string Case { get; set; }
        public string FontWeight {get; set;}
        
    }

    public class Highlighter
    {
        private List<Keyword> Keywords;

        public Highlighter(List<Keyword> keywords)
        {
            this.Keywords = keywords;
        }

        public string Highlight(string input)
        {
            foreach(var keyword in Keywords)
            {
                input = input.Replace(keyword.Word, 
                "[" + keyword.Color + "]"
                + ( string.Compare(keyword.FontWeight, "bold", true) == 0 ? "[" + keyword.FontWeight + "]" : "" ) 
                + (string.Compare(keyword.Case, "lower", true) == 0 ? keyword.Word.ToLower() : keyword.Word.ToUpper()) 
                + ( string.Compare(keyword.FontWeight, "bold", true) == 0 ? "[" + keyword.FontWeight + "]" : "" ) 
                + "[" + keyword.Color + "]");
            }

            return input;
        }
    }
}
