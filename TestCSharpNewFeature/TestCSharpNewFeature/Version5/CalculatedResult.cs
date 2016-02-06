using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCSharpNewFeature.Version5
{
    class CalculatedResult
    {
        public int? Number { get; set; }

        public static void First(object obj)
        {
            CalculatedResult result = obj as CalculatedResult;
            result = result ?? new CalculatedResult() { Number = 4 };
            result.Number *= 2;
        }

        public static int? Second(Task task)
        {
            CalculatedResult result = task.AsyncState as CalculatedResult;
            return result?.Number * result?.Number;
        }
    }
}
