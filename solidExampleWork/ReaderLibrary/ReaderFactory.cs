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

        public ReaderBase GetReader()
        {
            string source = ConfigurationManager.AppSettings.Get("ValueSource"); // appconfig te valuesoure denen değerin içinde nereden okunacagı yazıyor onu okur Factoryye yollar

            if (source == "Appconfig")
            {
                return new AppconfigReader();
            }
            else if (source == "Registry")
            {
                return new RegistryReader();
            }
            else
            {
                throw new NotImplementedException();
            }
        }

       
    }
}
