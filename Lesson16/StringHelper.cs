using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16
{
    public static class StringHelper
    {
        public static string ToCapitalize(this string word)
        {
            return word[0].ToString().ToUpper() + word.Substring(1);
        }
    }
}
