using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCSharpNewFeature.Version4
{
    static class CovariantAndContravariantTester
    {
        public static void TestCovariantAndContravariant()
        {
            Func<object, ArgumentException> function1 = Test;
            ArgumentException argumentException1 = function1("aaaa");

            Func<string, Exception> function2 = null;
            //convariant & contravariant
            //param is object -> string
            //return value is ArgumentException -> Exception
            //always use base class
            function2 = function1;
            Exception exception2 = function2("bbbb");

            Console.WriteLine(string.Format("argumentException type: {0}, exception type: {1}", argumentException1.GetType(), exception2.GetType()));
            Console.WriteLine("original");

            function2 = Test2;
            exception2 = function2("cccc");

            Console.WriteLine(string.Format("argumentException type: {0}, exception type: {1}", argumentException1.GetType(), exception2.GetType()));
        }

        private static ArgumentException Test(object obj)
        {
            return new ArgumentException(obj.ToString());
        }

        private static Exception Test2(string message)
        {
            return new Exception(message);
        }
    }
}
