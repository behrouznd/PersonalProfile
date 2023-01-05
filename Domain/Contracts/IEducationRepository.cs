using Entities.Models;

namespace Contracts;
public interface IEducationRepository
{
    Education GetEducation(Guid id, bool trackChanges);
    IEnumerable<Education> GetByIds(IEnumerable<Guid> ids, bool trackChanges);
    void DeleteEducation(Education education);
}

