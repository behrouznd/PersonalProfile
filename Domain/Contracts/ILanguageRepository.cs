using Entities.Models;

namespace Contracts;
public interface ILanguageRepository
{
    IEnumerable<Language> GetAllLanguages(bool trackChanges);
}

