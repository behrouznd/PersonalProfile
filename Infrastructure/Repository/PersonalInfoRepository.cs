using Contracts;
using Entities.Models;

namespace Repository
{
    public class PersonalInfoRepository : RepositoryBase<PersonalInfo> , IPersonalInfoRepository
    {
        public PersonalInfoRepository(RepositoryContext repositoryContext ) : base( repositoryContext )
        {
        }
    }
}
