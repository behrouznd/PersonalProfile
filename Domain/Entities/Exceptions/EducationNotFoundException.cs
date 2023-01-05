namespace Entities.Exceptions
{
    public sealed class EducationNotFoundException : NotFoundException
    {
        public EducationNotFoundException(Guid id):base($"The Education with id:{id} doesn't exists in database")
        {

        }
    }
}
