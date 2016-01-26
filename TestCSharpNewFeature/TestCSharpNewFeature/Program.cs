﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using TestCSharpNewFeature.Version6;
using static System.Math;
using static TestCSharpNewFeature.Version6.StaticClass;

namespace TestCSharpNewFeature
{
    class Program
    {
        /// <summary>
        /// http://blog.jobbole.com/79925/
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {


            TestNewFeatureOfVersion6();

            Console.Read();
        }

        #region Version 6
        private static void TestNewFeatureOfVersion6()
        {
            //property to init value
            AutoProperty property = new AutoProperty();
            Console.WriteLine(property.Name);
            Console.WriteLine(property.Sex);

            //lambda to method
            Lambda lambda = new Lambda(1, 1);
            var newPoint = lambda.Move(2, 3);
            Console.WriteLine(newPoint.ToString());

            //using static   there are something wrong on web resource
            Console.WriteLine(Sqrt(121));
            Console.WriteLine(Add(1, 2));

            //Null-conditional operators
            NullConditionalOperators();

            //String interpolation   there are something wrong on web resource
            var format = new StringFormat() { FirstName = "Lu", LastName = "Michael" };
            Console.WriteLine(format.ToString());

            //nameof
            var testName = "hahah";
            Console.WriteLine(nameof(testName));
            Console.WriteLine(testName);

            //Index initializers
            var numbers = new Dictionary<int, string>() { [2] = "two", [4] = "four", [6] = "six" };
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            //Exception filters   catch (ArgumentNullException e) when (e.ParamName == "bbbb")  it use "when" not "if" like example
            try
            {
                throw new ArgumentNullException("aaa");
            }
            catch (ArgumentNullException e) when (e.ParamName == "bbbb")
            {
                Console.WriteLine(e.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("not catch by ArgumentNullException");
            }

            //Await in catch/finally catch和finally块中的await
            Task<Resource> task = TryOpenResource();
            task.Wait();
            Console.WriteLine($"taskResult { task.Result.IsOpened }");


            //not support no parameter of struct constructor , it is so weird

            bool outParameter;
            TestOutParameter(true, out outParameter);
            Console.Write($"outParameter: { outParameter }");
        }

        private static void NullConditionalOperators()
        {
            List<int> items = null;
            var length = items?.Count;
            Console.WriteLine(length == null);

            var first = items?[0];
            Console.WriteLine(first == null);
        }

        private async static Task<Resource> TryOpenResource()
        {
            Resource res = null;
            try
            {
                res = await Resource.OpenAsync(); // You could do this.
            }
            catch (ResourceException e)
            {
                await Resource.LogAsync(res, e); // Now you can do this …
            }
            finally
            {
                if (res != null) await res.CloseAsync(); // … and this.
            }

            return res;
        }

        private static void TestOutParameter(bool isSuccessful, out bool canUseOutParameter)
        {
            canUseOutParameter = true;
        }
        #endregion

    }
}