using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReaderLibrary
{
     abstract class BaseReader // abstract ve template
    {
        object value = null;
        protected abstract object GetValue(string referances);
         
        public T ConvertValue<T>(string referances)
        {
            this.value = GetValue(referances);
            return ConvertHelperLibrary.Converter.convert<T>(value);
        }
        
    }
}
