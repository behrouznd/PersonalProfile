using Contracts;
using Entities.Models;

namespace Repository
{
    public class ContactRepository : RepositoryBase<Contact> , IContactRepository
    {
        public ContactRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
