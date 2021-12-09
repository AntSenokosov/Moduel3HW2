using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module3HW2.Models;
namespace Module3HW2
{
    public class DictionaryContacts<TKey, TValue> : Dictionary<string, List<Contact>>
    {
        public DictionaryContacts()
        : base()
        {
        }

        public DictionaryContacts(int capacity)
            : base(capacity)
        {
        }

        public void AddContact(Contact contact)
        {
            List<Contact> contacts;
            string key;
            if (contact.FullName == string.Empty)
            {
                key = contact.Phone.Substring(0, 1);
            }
            else
            {
                key = contact.FullName.Substring(0, 1).ToUpper();
            }

            if (key[0] >= '0' && key[0] <= '9')
            {
                key = "0-9";
            }

            if (!(key[0] >= '0' && key[0] <= '9') && !((key[0] >= 'A' && key[0] <= 'Z') || (key[0] >= 'А' && key[0] <= 'Я')))
            {
                key = "#";
            }

            if (TryGetValue(key, out contacts))
            {
                contacts.Add(contact);
            }
            else
            {
                contacts = new List<Contact>();
                contacts.Add(contact);
                Add(key, contacts);
            }
        }

        public bool Remove(Contact contact)
        {
            List<Contact> contacts;
            string key = contact.FullName.Substring(0, 1);

            if (TryGetValue(key, out contacts))
            {
                if (contacts.Remove(contact))
                {
                    if (contacts.Count == 0)
                    {
                        Remove(key);
                    }

                    return true;
                }
            }

            return false;
        }
    }
}
