using System;
using System.Collections.Generic;
using System.Text;

namespace StructVsClass
{
    class PointC
    {
        private int _x;
        private int _y;

        public PointC(int x, int y)
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
