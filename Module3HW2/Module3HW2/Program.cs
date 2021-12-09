using System;
using System.Collections.Generic;
using System.Globalization;
using Module3HW2.Models;
using Module3HW2.Configs;

namespace Module3HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            var culture = CultureInfo.CurrentCulture.Name;

            var config = new ConfigCulture();

            CultureInfo newCulture;

            foreach (var cult in config.InitCultures())
            {
                if (culture == cult.Key)
                {
                    newCulture = new CultureInfo(culture);
                }
            }

            newCulture = new CultureInfo("ru-US");

            var dict = new DictionaryContacts<string, List<Contact>>();

            dict.AddContact(new Contact { FirstName = "Vova", LastName = "Gricak", Phone = "2353252352" });

            dict.AddContact(new Contact { FirstName = "vlad", LastName = "TRE", Phone = "2456312345" });

            dict.AddContact(new Contact { FirstName = "Anton", LastName = "Senokosov", Phone = "0997534950" });

            dict.AddContact(new Contact { FirstName = string.Empty, LastName = string.Empty, Phone = "092332523523" });
            dict.AddContact(new Contact { FirstName = "0662332523523" });
            dict.AddContact(new Contact { FirstName = "$21332" });

            foreach (var obj in dict)
            {
                Console.WriteLine(obj.Key);
                foreach (var v in obj.Value)
                {
                    Console.WriteLine(v.FullName + " " + v.Phone);
                }
            }

            Console.ReadKey();
        }
    }
}
