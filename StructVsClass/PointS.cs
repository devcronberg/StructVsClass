using System;
using System.Collections.Generic;
using System.Text;

namespace StructVsClass
{
    struct PointS
    {
        private int _x;
        private int _y;

        public PointS(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public string Print()
        {
            return $"{_x},{_y}";
        }
    }
}
