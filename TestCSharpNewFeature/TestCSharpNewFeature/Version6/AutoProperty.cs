using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCSharpNewFeature.Version6
{
    class AutoProperty
    {
        public string Name { get; set; } = "Michael";

        public string Sex { get; } = "Male";

        public AutoProperty()
        {
            this.Sex = "Female";
        }
    }
}
