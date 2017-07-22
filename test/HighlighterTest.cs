using System;
using src;
using Xunit;

namespace test
{
    public class HighligherTest
    {
        [Fact]
        public void Should_Find_Keywords_In_Given_Input_String()
        {
            var keywords = new string[] {"as:blue", "If:red", "and:red", "then:green", "when:blue"};
            var highlighter = new Highlighter(keywords);
            string input = "If we write a program and compile it, then as we run the program, we will get output";
            string actual = highlighter.FindAndHighlight(input);
            string expected = "[red]If[red] we write a program [red]and[red] compile it, [green]then[green] [blue]as[blue] we run the program, we will get output";
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Should_Return_Input_String_As_Is_If_No_Keyword_Is_Found()
        {
            var keywords = new string[] {"as:blue", "If:red", "and:red", "then:green", "when:blue"};
            var highlighter = new Highlighter(keywords);
            string input = "No keyword found.";
            string output = highlighter.FindAndHighlight(input);
            Assert.Equal(input, output);
        }


    }
}
