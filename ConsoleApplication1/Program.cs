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
            //var beam = new MCalcLib.objects.objectBeam();
            //beam.ApplyStandard(new MCalcLib.classes.Standard());
            var fixture = new MCalcLib.objects.objectFixture(10.0);
            Console.WriteLine(fixture.ToString());
            Console.ReadKey();
            
        }
    }
}
