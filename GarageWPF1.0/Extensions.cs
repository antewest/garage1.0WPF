using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageWPF1._0
{
    static class Extensions
    {
        public static object GetProperty<T>(this T obj, string name) where T : Vehicle
        {
            Type t = typeof(T);
            return t.GetProperty(name).GetValue(obj);
            //tds
        }
    }
}
