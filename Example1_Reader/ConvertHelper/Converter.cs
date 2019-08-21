using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertHelperLibrary
{
    public class Converter
    {
        public static T convert<T>(object input)
        {
            return (T)Convert.ChangeType(input, typeof(T));

        }
    }
}
