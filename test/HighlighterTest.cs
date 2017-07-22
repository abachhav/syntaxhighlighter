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
            var highlighter = new Highlighter();
            string input = "If we write a program and compile it, then we can run the program to get output";
            string actual = highlighter.FindAndHighlight(input);
            string expected = "[blue]If[blue] we write a program [blue]and[blue] compile it, [blue]then[blue] we can run the program to get output";
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Should_Return_Input_String_As_Is_If_No_Keyword_Is_Found()
        {
            var highlighter = new Highlighter();
            string input = "No keyword found.";
            string output = highlighter.FindAndHighlight(input);
            Assert.Equal(input, output);
        }


    }
}
