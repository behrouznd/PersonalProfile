using Entities.Models;

namespace Contracts;
public interface ILanguageRepository
{
    IEnumerable<Language> GetAllLanguages(bool trackChanges);
    Language GetLanguage(Guid languageId, bool trackChanges);
    void CreateLanguage(Language language);
    void DeleteLanguage(Language language);
}

