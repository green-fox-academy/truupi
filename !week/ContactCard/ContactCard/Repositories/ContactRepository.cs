using ContactCardApp.Entities;
using ContactCardApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace ContactCardApp.Repositories
{
    public class ContactRepository
    {
        ContactContext contactContext;

        public ContactRepository(ContactContext contactContext)
        {
            this.contactContext = contactContext;
        }

        public List<ContactCard> ListCards()
        {
            return contactContext.ContactCards.ToList();
        }

        public ContactCard ShowSpecificCard(int id)
        {
            return ListCards().FirstOrDefault(card => card.Id == id);
        }
    }
}
