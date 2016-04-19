using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCSharpNewFeature.Version3
{
    public static class StaticMethodTester
    {
        public static string RemoveComma(this string content)
        {
            return content.Replace(",", "");
        }
    }
}
