using Shared.DataTransferObject;

namespace Service.Contracts
{
    public interface IEducationService
    {
        IEnumerable<EducationDto> GetByIds(IEnumerable<Guid> ids, bool trackChanges);

        void DeleteEducationForPersonalInfo(Guid personalInfoId, Guid id, bool trackChanges);
    }
}
