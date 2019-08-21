using System;
using System.Collections.Generic;
using System.Linq;

namespace StructVsClass
{
    class Program
    {
        static void Main(string[] args)
        {

            int count = 5_000_000;
            int iterations = 10;

            List<long> structResults = new List<long>();
            List<long> classResults = new List<long>();

            Console.WriteLine("Struct");
            for (int i = 0; i < iterations; i++)
            {
                structResults.Add(TestStruct(count));
                Console.Write(".");
            }
            Console.WriteLine($"\r\nms: {structResults.Sum() / iterations}");

            Console.WriteLine("Class");
            for (int i = 0; i < iterations; i++)
            {
                classResults.Add(TestClass(count));
                Console.Write(".");
            }
            Console.WriteLine($"\r\nms: {classResults.Sum() / iterations}");

        }

        static long TestStruct(int count)
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

        static long TestClass(int count)
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
