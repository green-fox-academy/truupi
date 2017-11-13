using ContactCardApp.Entities;
using ContactCardApp.Models;
using System.Collections.Generic;
using System.Linq;
using System;

namespace ContactCardApp.Repositories
{
    public class ContactRepository
    {
        ContactContext ContactContext;

        public ContactRepository(ContactContext contactContext)
        {
            ContactContext = contactContext;
        }

        public List<ContactCard> ListCards()
        {
            return ContactContext.ContactCards.ToList();
        }

        public ContactCard ShowSpecificCard(int id)
        {
            return ListCards().FirstOrDefault(card => card.Id == id);
        }

        public void AddCardToDatabase(ContactCard inputContact)
        {
            ContactContext.ContactCards.Add(inputContact);
            ContactContext.SaveChanges();
        }
    }
}
