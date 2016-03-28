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
            var standard = MCalcLib.classes.Standard.Init<objectBeam>();
            //standard.Bounds["h"] = 10;
            //standard.Bounds["b"] = 100;
            //standard.Bounds["S"] = 1000;
            //standard.Bounds["t"] = 10000;

            var beam = new objectBeam(standard);
            //Console.WriteLine(fixture.ToString());
            Console.ReadKey();
            
        }
    }
}
