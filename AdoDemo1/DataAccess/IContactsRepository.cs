using AdoDemo1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoDemo1.DataAccess
{
    public interface IContactsRepository
    {
        bool SaveContact(Contact contact);
        bool DeleteContact(int contactId);
        bool UpdateContact(int contactId, Contact modifiedContact);
        /// <summary>
        /// searches contact by id
        /// </summary>
        /// <param name="contactId"></param>
        /// <returns>contact object</returns>
        /// <exception cref="ContactNotFoundException"/>
        Contact GetContactById(int contactId);
        List<Contact> GetContacts();
        List<Contact> GetContactsByLocation(string location);
        List<Contact> GetContactsBornedToday();

        List<Contact> GetContactsBornedThisMonth();

        /// <summary>
        /// transfer amount from fromAccNo to toAccNo provided sufficcient balance in source account otherwise throws appropriate exp
        /// </summary>
        /// <param name="fromAccNo"></param>
        /// <param name="toAccNo"></param>
        /// <param name="amount"></param>
        /// <returns></returns>
        bool FundTransfer(int fromAccNo, int toAccNo, int amount);

    }
}
