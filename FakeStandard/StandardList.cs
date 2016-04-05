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
            Initialize();
        }

        public void Initialize()
        {
            #region --BEAM--
            standards.Add(Standard.Init<objectBeam>(
                new Hashtable {
                        { "h", 10.0 },
                        { "b", 10.0 },
                        { "S", 10.0 },
                        { "t", 10.0 }
                        },
                        1));

            standards.Add(Standard.Init<objectBeam>(
                new Hashtable {
                        { "h", 100.0 },
                        { "b", 100.0 },
                        { "S", 100.0 },
                        { "t", 100.0 }
                        },
                        2));

            standards.Add(Standard.Init<objectBeam>(
                new Hashtable {
                        { "h", 20 },
                        { "b", 50 },
                        { "S", 5 },
                        { "t", 15 }
                        },
                        2.5));

            standards.Add(Standard.Init<objectBeam>(
                new Hashtable {
                        { "h", 30 },
                        { "b", 45 },
                        { "S", 7 },
                        { "t", 20 }
                        },
                        3));

            #endregion

            #region --CHANNEL--
            standards.Add(Standard.Init<objectStandardChannel>(
                new Hashtable
                {
                    {"h",10 },
                    {"a",20 },
                    {"s",1 }
                },
                0.5
                ));

            standards.Add(Standard.Init<objectStandardChannel>(
                new Hashtable
                {
                    {"h",10 },
                    {"a",20 },
                    {"s",1 }
                },
                1
                ));
            standards.Add(Standard.Init<objectStandardChannel>(
                new Hashtable
                {
                    {"h",10 },
                    {"a",20 },
                    {"s",1 }
                },
                2
                ));
            standards.Add(Standard.Init<objectStandardChannel>(
                new Hashtable
                {
                    {"h",10 },
                    {"a",20 },
                    {"s",1 }
                },
                3
                ));
            standards.Add(Standard.Init<objectStandardChannel>(
                new Hashtable
                {
                    {"h",10 },
                    {"a",20 },
                    {"s",1 }
                },
                4
                ));
            #endregion
        }
    }
}
