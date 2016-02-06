using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCSharpNewFeature.Version6
{
    class StringFormat
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString() => $"This is the first name : { FirstName }, that is the last name: { LastName }";

    }
}
