using System;
using System.Collections.Generic;

namespace StructVsClass
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(TestStruct());
                Console.WriteLine(TestClass());
                Console.WriteLine();
            }
        }

        static long TestStruct(int count = 1_000_000)
        {
            var lst = new PointS[count];
            System.Diagnostics.Stopwatch s = new System.Diagnostics.Stopwatch();
            s.Start();
            for (int i = 0; i < count; i++)
            {
                lst[i] = new PointS(i, i);
            }
            s.Stop();
            return s.ElapsedMilliseconds;
        }

        static long TestClass(int count = 1_000_000)
        {
            var lst = new PointC[count];
            System.Diagnostics.Stopwatch s = new System.Diagnostics.Stopwatch();
            s.Start();
            for (int i = 0; i < count; i++)
            {
                lst[i] = new PointC(i, i);
            }
            s.Stop();
            return s.ElapsedMilliseconds;
        }
    }
}
