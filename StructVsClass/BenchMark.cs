using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace StructVsClass
{
    [RPlotExporter, RankColumn]
    [MemoryDiagnoser]
    public class BenchMark
    {
        private int count = 10;
        private int iterations = 1_000;

        [Benchmark]
        public void TestStruct()
        {

            for (int x = 0; x < iterations; x++)
            {
                var lst = new PointS[count];
                for (int i = 0; i < count; i++)
                {
                    lst[i] = new PointS(i, i);
                }
            }            
        }

        [Benchmark]
        public void TestClass()
        {

            for (int x = 0; x < iterations; x++)
            {
                var lst = new PointC[count];
                for (int i = 0; i < count; i++)
                {
                    lst[i] = new PointC(i, i);
                }
            }
        }
    }
}
