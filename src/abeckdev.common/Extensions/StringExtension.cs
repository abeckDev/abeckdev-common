using System;
using System.Collections.Generic;
using System.Text;

namespace AbeckDev.Common.Extensions
{
    public static class StringExtension
    {
        public static Dictionary<string, string> ToDictonary(this String input, char seperator)
        {
            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
            foreach (var keyvalue in input.TrimEnd(seperator).Split(seperator))
            {
                keyValuePairs.Add(keyvalue.Split('=')[0], keyvalue.Split('=')[1]);
            }
            return keyValuePairs;
        }
    }
}
