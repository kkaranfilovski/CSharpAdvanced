using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    public static class StringExtensions
    {
        public static string DeleteLastCharacterWithExtension(this string text)
        {
            return text.Substring(0, text.Length - 1);
        }

        public static string DeleteLastCharacterWithoutExtension(string text)
        {
            return text.Substring(0, text.Length - 1);
        }

        public static string AddQuataions(this string text)
        {
            return @$"""{ text}""";
        }
    }
}
