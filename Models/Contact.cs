using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactCatalog.Models
{
    public class Contact
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Tag { get; set; }

        public Contact(string id, string name, string email, string tag)
        {
            Id = id;
            Name = name;
            Email = email;
            Tag = tag;
        }
    }
}
