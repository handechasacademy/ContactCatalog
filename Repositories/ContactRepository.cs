using ContactCatalog.Models;

namespace ContactCatalog.Repositories
{
    public class ContactRepository
    {
        private Dictionary<int, Contact> _contacts = new();

        public void SaveContact(Contact contact)
        {
            Console.Write("Enter contact Id: ");
            string idToBeAdded = Console.ReadLine();
            if (!int.TryParse(idToBeAdded, out int contactId))
            {
                Console.WriteLine("Invalid Id. Contact not saved.");
                return;
            }

            if (_contacts.ContainsKey(contactId))
            {
                Console.WriteLine("Contact already exists.");
                return;
            }

            contact.Id = contactId;

            Console.Write("Enter contact name: ");
            string nameToBeAdded = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(nameToBeAdded))
            {
                Console.WriteLine("Name cannot be empty. Try again.");
                return;
            }
            contact.Name = nameToBeAdded;

            Console.Write($"Enter email for {nameToBeAdded}: ");
            string emailToBeAdded = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(emailToBeAdded))
            {
                Console.WriteLine("Email cannot be empty. Try again.");
                return;
            }
            contact.Email = emailToBeAdded;

            Console.Write("Enter a tag for this contact: ");
            string tagToBeAdded = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(tagToBeAdded))
            {
                Console.WriteLine("Tag cannot be empty. Try again.");
                return;
            }
            contact.Tags = new List<string> { tagToBeAdded };

            _contacts.Add(contact.Id, contact);
            Console.WriteLine($"-{contact.Name} has been added to contacts.");
        }




        public void RemoveContact()
        {
            Console.Write("Enter the ID of the contact you want to remove: ");
            string idInput = Console.ReadLine();

            if (!int.TryParse(idInput, out int idToRemove))
            {
                Console.WriteLine("Invalid ID.");
                return;
            }

            if (!_contacts.ContainsKey(idToRemove))
            {
                Console.WriteLine("Contact doesn't exist.");
                return;
            }
            else
            {
                Contact contactToRemove = _contacts[idToRemove];
                _contacts.Remove(idToRemove);
                Console.WriteLine($"{contactToRemove.Name} has been removed.");
            }

        }



        public void ListContacts()
        {
            if (_contacts.Count == 0)
            {
                Console.WriteLine("No contacts to list.");
                return;
            }

            Console.WriteLine("Contacts list:");
            foreach (var contact in _contacts.Values)
            {
                Console.WriteLine($"Id: {contact.Id}, Name: {contact.Name}, Email: {contact.Email}, Tags: {string.Join(", ", contact.Tags)}");
            }
        }


        public void UpdateContact()
        {
            Console.WriteLine("Enter id for the contact you wanna update:");
            string idInput = Console.ReadLine();
            if (int.TryParse(idInput, out int idToBeFound))
            {
                if (_contacts.ContainsKey(idToBeFound))
                {
                    Contact contactToUpdate = _contacts[idToBeFound];

                    Console.WriteLine("What field do you want to update? (Name/Email/Tag)");
                    string fieldInput = Console.ReadLine();
                    if (fieldInput.Equals("name", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Please write the new name.");
                        string nameInput = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(nameInput))
                        {
                            contactToUpdate.Name = nameInput;
                            Console.WriteLine($"Contact name has been updated to {nameInput}.");
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. I am calling the police!");
                            return;
                        }
                    }
                    else if (fieldInput.Equals("email", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Please write the new email.");
                        string emailInput = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(emailInput))
                        {
                            contactToUpdate.Email = emailInput;
                            Console.WriteLine($"Contact email has been updated to {emailInput}.");

                        }
                        else
                        {
                            Console.WriteLine("Invalid input. I am calling the police!");
                            return;
                        }
                    }
                    else if (fieldInput.Equals("tag", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Do you wanna remove a tag or add one? (Write 'Add' for adding, 'Remove' for removing.");
                        string choiceForTagInput = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(choiceForTagInput))
                        {
                            if (choiceForTagInput.Equals("Add", StringComparison.OrdinalIgnoreCase))
                            {
                                Console.WriteLine("Enter tag name to add.");
                                string tagToAdd = Console.ReadLine();
                                if (!string.IsNullOrWhiteSpace(tagToAdd))
                                {
                                    contactToUpdate.Tags.Add(tagToAdd);
                                    Console.WriteLine($"Tag '{tagToAdd}' added.");
                                }
                                else
                                {
                                    Console.WriteLine("Invalid input. I am calling the police!");
                                    return;
                                }
                            }
                            else if (choiceForTagInput.Equals("Remove", StringComparison.OrdinalIgnoreCase))
                            {
                                Console.WriteLine("Enter tag name to remove.");
                                string tagToRemove = Console.ReadLine();
                                if (!string.IsNullOrWhiteSpace(tagToRemove))
                                {
                                    contactToUpdate.Tags.Remove(tagToRemove);
                                    Console.WriteLine($"Tag '{tagToRemove}' has been removed.");
                                }
                                else
                                {
                                    Console.WriteLine("Invalid input. I am calling the police!");
                                    return;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. I am calling the police!");
                                return;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. I am calling the police!");
                            return;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. I am calling the police!");
                        return;
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid input. I am calling the police!");
                return;
            }
        }


    }
}
