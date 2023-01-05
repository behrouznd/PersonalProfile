using Entities.Models;

namespace Contracts;
public interface IEducationRepository
{
    IEnumerable<Education> GetByIds(IEnumerable<Guid> ids, bool trackChanges);
}

