using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCSharpNewFeature.Version3
{
    public static class LambdaExpressionTester
    {
        delegate void TestDelegate();
        static void Method()
        {
            Console.WriteLine("This is a normal way to show");
        }

        public static void TestNormalPlan()
        {
            //TestNormal tester = Method;
            TestDelegate tester = new TestDelegate(Method);
            tester();
        }

        public static void TestAnonymityMethodPlan()
        {
            TestDelegate tester = delegate () { Console.WriteLine("This is anonymity method way to show"); };
            tester();
        }

        public static void TestLambdaExpressionPlan()
        {
            TestDelegate tester = () => { Console.WriteLine("This is lambda expression way to show"); };
            tester();
        }
    }
}
