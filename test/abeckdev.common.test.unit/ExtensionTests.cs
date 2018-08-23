using System;
using Xunit;
using AbeckDev.Common.Services;
using AbeckDev.Common.Extensions;
using System.Collections.Generic;

namespace AbeckDev.Common.Test.Unit
{
    public class ExtensionTests
    {


        [Fact]
        public void ExtractDictonaryShortbyComma()
        {
            Dictionary<string, string> correctDictonary = new Dictionary<string, string>();
            correctDictonary.Add("KeyA", "ValueA");
            correctDictonary.Add("KeyB", "ValueB");
            Assert.Equal<Dictionary<string, string>>("KeyA=ValueA,KeyB=ValueB".ToDictonary(','), correctDictonary);
        }

        [Fact]
        public void ExtractDictonaryShortbySemicolon()
        {
            Dictionary<string, string> correctDictonary = new Dictionary<string, string>();
            correctDictonary.Add("KeyA", "ValueA");
            correctDictonary.Add("KeyB", "ValueB");
            Assert.Equal<Dictionary<string, string>>("KeyA=ValueA;KeyB=ValueB".ToDictonary(';'), correctDictonary);
        }

        [Fact]
        public void ExtractDictonaryLongbyComma()
        {
            Dictionary<string, string> correctDictonary = new Dictionary<string, string>();
            correctDictonary.Add("KeyA", "ValueA");
            correctDictonary.Add("KeyB", "ValueB");
            correctDictonary.Add("KeyC", "ValueC");
            Assert.Equal<Dictionary<string, string>>("KeyA=ValueA,KeyB=ValueB,KeyC=ValueC".ToDictonary(','), correctDictonary);
        }

        [Fact]
        public void ExtractDictonaryLongbySemicolon()
        {
            Dictionary<string, string> correctDictonary = new Dictionary<string, string>();
            correctDictonary.Add("KeyA", "ValueA");
            correctDictonary.Add("KeyB", "ValueB");
            correctDictonary.Add("KeyC", "ValueC");
            Assert.Equal<Dictionary<string, string>>("KeyA=ValueA;KeyB=ValueB;KeyC=ValueC".ToDictonary(';'), correctDictonary);
        }
    }
}
