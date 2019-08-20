using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReaderLibrary
{
     abstract class ReaderBase // abstract ve template
    {
        object value = null;
        protected abstract object GetValue(string referances);

        private static SortedList values = new SortedList();

        public T ReadFromMemory<T>(string referances)
        {
                Console.WriteLine("değer Hafızadan okundu");
                int index = values.IndexOfKey(referances);
                return ConvertHelperLibrary.Converter.convert<T>((values.GetByIndex(index)));
          }

        public T ReadValue<T>(string referances)
        {
            if (values.ContainsKey(referances))
                return ReadFromMemory<T>(referances);
            this.value = GetValue(referances);
            values.Add(referances, value);
            return ConvertHelperLibrary.Converter.convert<T>(value);
        }
        
    }
}
