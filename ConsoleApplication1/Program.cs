using MCalcLib.objects;
using MCalcLib.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            MCalcLib.classes.StandardsList list = new StandardsList();
            Console.WriteLine(@"Lenth: {0} Capacity {1}", list.Length, list.Capacity);

            for (int i = 0; i < 100;i++ )
            {
                list.Add(Standard.Init<objectBeam>());
            }

            Console.WriteLine(@"Lenth: {0} Capacity {1}", list.Length, list.Capacity);

            for (int i = 0; i < 100; i++)
            {
                list.Add(Standard.Init<objectStandardChannel>());
            }

            Console.WriteLine(@"Lenth: {0} Capacity {1}", list.Length, list.Capacity);

            Console.WriteLine(list[5]);
            Console.WriteLine(list[188]);
            Console.WriteLine(list[205]);

                Console.ReadKey();
            
        }
    }
}
