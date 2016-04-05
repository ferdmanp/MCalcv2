using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using MCalcLib.attributes;

namespace MCalcLib.classes
{
    public class Standard
    {
        public Standard()
        {
            this.Bounds = new BoundsList();
        }

        /// <summary>
        /// Название стандарта
        /// </summary>
        public string Name { get; set; }

        

        /// <summary>
        /// Описание ГОСТа
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Ссылка на группу-родителя
        /// </summary>
        public StandardGroup StandardGroup;

        /// <summary>
        /// таблица габаритных свойств
        /// </summary>
        public BoundsList Bounds;// { get; set; }

        /// <summary>
        /// Вес 1м погонного
        /// </summary>
        public double StandardDensityWeight { get; set; }

        
        public static Standard Init<T>() where T : objects.objectStandardItemBase
        {
            Standard standard = new Standard();
            Type type = typeof(T);

            foreach(var prop in type.GetProperties())
            {
                foreach(var attr in prop.GetCustomAttributes(typeof(BoundAttribute),false))
                {
                    string key = ((BoundAttribute)attr).StandardName;
                    standard.Bounds[key] = 1.0;
                    standard.StandardDensityWeight = 1.0;
                }
            }

            return standard;
        }

        public static Standard Init<T>(BoundsList bounds) where T : objects.objectStandardItemBase
        {
            Standard standard = new Standard();
            Type type = typeof(T);

            foreach (var prop in type.GetProperties())
            {
                foreach (var attr in prop.GetCustomAttributes(typeof(BoundAttribute), false))
                {
                    string key = ((BoundAttribute)attr).StandardName;
                    standard.Bounds[key] = bounds[key];                    
                }
            }

            return standard;
        }

        public static Standard Init<T>(Hashtable paramsTable) where T : objects.objectStandardItemBase
        {
            Standard standard = new Standard();

            Type type = typeof(T);

            foreach (var prop in type.GetProperties())
            {
                foreach (var attr in prop.GetCustomAttributes(typeof(BoundAttribute), false))
                {
                    string key = ((BoundAttribute)attr).StandardName;
                    if (paramsTable.ContainsKey(key))
                    {
                        standard.Bounds[key] = Convert.ToDouble(paramsTable[key]);
                    } else { /*DO NOTHING*/}
                }
            }

            return standard;
        }



        public override string ToString()
        {
            return base.ToString();

        }
    }
}
