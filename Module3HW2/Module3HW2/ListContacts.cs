using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module3HW2.Models;

namespace Module3HW2
{
    public class ListContacts
    {
        private readonly List<Contact> _contacts;

        public ListContacts()
        {
            _contacts = new List<Contact>();
        }

        public void AddContact(Contact contact)
        {
            _contacts.Add(contact);
        }

        public void RemoveContact(Contact contact)
        {
            _contacts.Remove(contact);
        }
    }
}
