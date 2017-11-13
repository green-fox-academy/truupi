using ContactCardApp.Models;
using ContactCardApp.Repositories;
using ContactCardApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactCardApp.Services
{
    public class ContactService
    {
        ContactRepository ContactRepository;

        public ContactService(ContactRepository contactRepository)
        {
            ContactRepository = contactRepository;
        }

        public void CreateContactCard(ContactCardViewModel inputContactCardViewModel)
        {
            if (inputContactCardViewModel.FirstName == null 
                || inputContactCardViewModel.LastName == null 
                || inputContactCardViewModel.Job == null
                || inputContactCardViewModel.EmailAddress == null)
            {
                return;
            }
            else
            {
                var inputContact = new ContactCard
            {
                FirstName = inputContactCardViewModel.FirstName,
                LastName = inputContactCardViewModel.LastName,
                Age = inputContactCardViewModel.Age,
                CompanyName = inputContactCardViewModel.CompanyName,
                Job = inputContactCardViewModel.Job,
                PhoneNum = inputContactCardViewModel.PhoneNum,
                EmailAddress = inputContactCardViewModel.EmailAddress,
                WebAddress = inputContactCardViewModel.WebAddress,
                ImageLink = inputContactCardViewModel.ImageLink,
                FacebookLink = inputContactCardViewModel.FacebookLink,
                InstagramLink = inputContactCardViewModel.InstagramLink,
                TwitterLink = inputContactCardViewModel.TwitterLink,
                LinkedInLink = inputContactCardViewModel.LinkedInLink
            };
                ContactRepository.AddCardToDatabase(inputContact);
            }
        }

        public ContactCard ShowSpecificCard(int id)
        {
            return ContactRepository.ShowSpecificCard(id);
        }

        public List<ContactCard> ListCards()
        {
            return ContactRepository.ListCards();
        }
    }
}
