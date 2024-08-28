using MvcContacts.EntityLayer;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MvcContacts.BusinessLayer
{
    public interface IContactService
    {
        Task<IEnumerable<Contact>> GetContactsAsync();
        Task<Contact> GetContactByIdAsync(int id);
        Task AddContactAsync(Contact contact);
        Task UpdateContactAsync(Contact contact);
        Task DeleteContactAsync(int id);
    }
}
