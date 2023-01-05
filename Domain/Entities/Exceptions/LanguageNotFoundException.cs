namespace Entities.Exceptions
{
    public sealed class LanguageNotFoundException : NotFoundException
    {
        public LanguageNotFoundException(Guid languageId) : base($"The language with id:{languageId} does not exist in Database")
        {
        }
    }
}
