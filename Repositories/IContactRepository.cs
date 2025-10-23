using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactCatalog.Models;

namespace ContactCatalog.Repositories
{
    public interface IContactRepository
    {
        void SaveContact(Contact contact);
        void RemoveContact(int id);
        List<Contact> SearchByName(string namePart);
        List<Contact> FilterByTag(string tag);
        List<Contact> ListContacts();
        void UpdateContact(int id);
    }
}

