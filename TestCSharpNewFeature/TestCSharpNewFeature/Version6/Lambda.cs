using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TestCSharpNewFeature.Version6
{
    class Lambda
    {
        private int x;
        private int y;

        public Lambda(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public Point Move(int dx, int dy) => new Point(x + dx, y + dy);

        public override string ToString() => x + "," + y;
    }
}
