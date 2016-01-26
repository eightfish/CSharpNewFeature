using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCSharpNewFeature.Version6
{
    public struct NoParameterStruct
    {
        public string Name { get; set; }

        public int Age { get; set;  }

        //not support no parameter of struct constructor , it is so weird
        //    Name = "Michael";
        //    Age = 33; 
        //}

    }

}
