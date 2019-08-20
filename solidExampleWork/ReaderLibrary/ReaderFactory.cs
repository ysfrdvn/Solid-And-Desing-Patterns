using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ReaderLibrary 
{
     class ReaderFactory
    {
        string source = ConfigurationManager.AppSettings.Get("ValueSource"); // appconfig te valuesoure denen değerin içinde nereden okunacagı yazıyor onu okur Factoryye yollar

        private static SortedList values = new SortedList();
       
       public T getValue<T>(string referances)
        {
            
            if (values.ContainsKey(referances))
            {
                Console.WriteLine("değer Hafızadan okundu");
                int index = values.IndexOfKey(referances);
                return ConvertHelperLibrary.Converter.convert<T>((values.GetByIndex(index)));
                
            }
       
            Console.WriteLine("değer kaynaktan okundu");
            if (source == "Appconfig") { 
                var value = new AppconfigReader().ConvertValue<T>(referances);
                values.Add(referances, value);
                return value;
            }
            else if (source == "Registry") { 
                var value = new RegistryReader().ConvertValue<T>(referances);
                values.Add(referances, value);
                return value;
            }
            else { 
                TypeConverter converter = TypeDescriptor.GetConverter(typeof(T));
                return (T)converter.ConvertFrom(null);
            }

        }
        


       
    }
}
