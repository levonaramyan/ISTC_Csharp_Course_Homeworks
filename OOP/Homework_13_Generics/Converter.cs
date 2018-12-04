using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_13_Generics
{
    static class Converter
    {
        // The method safely converts any input of type U into type T
        // if it is not possible to convert, return the default value of type T
        public static T StringToType<T,U>(U s)
        {
            Type myType = typeof(T);
            T res;
            try
            {
                res = (T)Convert.ChangeType(s, myType);
            }
            catch
            {
                res = default;
            }

            return res;
        }
    }
}
