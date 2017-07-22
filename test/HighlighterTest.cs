using System;
using src;
using Xunit;
using System.Collections.Generic;

namespace test
{
    public class HighligherTest
    {
        [Fact]
        public void Should_Find_Keywords_In_Given_Input_String()
        {
            var keywords = new List<Keyword> 
            {
                new Keyword(){ Word = "as", Color = "blue", Case = "Capital" },
                new Keyword(){ Word = "If", Color = "red", Case = "lower" },
                new Keyword(){ Word = "and", Color = "red", Case = "Capital" },
                new Keyword(){ Word = "then", Color = "green", Case = "lower" },
                new Keyword(){ Word = "when", Color = "blue", Case = "Capital" }
            } ;

            var highlighter = new Highlighter(keywords);
            string input = "If we write a program and compile it, then as we run the program, we will get output";
            string actual = highlighter.Highlight(input);
            string expected = "[red]if[red] we write a program [red]AND[red] compile it, [green]then[green] [blue]AS[blue] we run the program, we will get output";
            
            Console.WriteLine(actual);
            
            Assert.Equal(expected, actual);

            
        }

    }
}
