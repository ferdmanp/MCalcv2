using MCalcLib.objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            MCalcLib.objects.objectItemBase fixture = new objectFixture { Diameter = 10 };
            Console.WriteLine(fixture.Name);
            Console.WriteLine(fixture.DensityWeight);
            Console.ReadKey();
        }
    }
}
