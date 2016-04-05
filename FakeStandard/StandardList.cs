using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MCalcLib.classes;
using MCalcLib.objects;
using System.Collections;

namespace FakeStandard
{
    public class StandardList
    {
        List<Standard> standards = new List<Standard>();
        

        public StandardList()
        {
            standards.Add(Standard.Init<objectBeam>(
                new Hashtable {
                        { "h", 10.0 },
                        { "b", 10.0 },
                        { "S", 10.0 },
                        { "t", 10.0 }
                        }));   
            
            standards.Add(Standard.Init<objectStandardChannel>(
                new Hashtable
                {
                    {"h",10 },
                    {"a",20 },
                    {"s",1 }
                }
                ));             
        }

        public void Initialize()
        {

        }
    }
}
