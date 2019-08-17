using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReaderLibrary
{
    public class ReadValue //  1inci 
    {
        static Dictionary<String, object> values = new Dictionary<String, object>(); // hafızada tuttugum yer
        static object findValue;
        public static T GetValue<T>(String referances)   // okuma için ilk çağırılan yer. Ben nerden okuyacağım seçimini bilmiyor. O yüzden Decisiona yollarız 
        {
            if (values.TryGetValue(referances, out findValue)) // eğer daha önce okuduysam git hafızadan getir
            {
                Console.WriteLine("değer hafızadan okundu!!");
                return ConvertHelperLibrary.Converter.convert<T>(findValue);
               
            }
            T value;
            Decision decision = new Decision();
            value = decision.getValue<T>(referances);
            values.Add(referances, (object)value);
            Console.WriteLine("Değer source dan okundu");
            return value;
        }

       // ValueReader.getValue("retro");
    }
}
